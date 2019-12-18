Public Class FormMain

    Private configPath As String

    Private status As New Collection
    Private charSet As New Collection
    Private initStatus As String
    Private blankChar As String
    Private finalStatus As New Collection
    Private transfer As New Dictionary(Of Trigger, Destination)
    Private str As New ArrayList
    Private hasReachedBlank As Boolean

    Private cntPos As Integer
    Private cntStatus As String
    Private lastPos As Integer

    Private Sub PaintGraph()
        dashboard.Clear()
        For i = 0 To str.Count - 1
            Dim cntCount As Integer = dashboard.TextLength
            dashboard.AppendText(str(i))
            If i = cntPos Then
                dashboard.Select(cntCount, str(i).ToString.Length)
                dashboard.SelectionBackColor = Color.Green
            ElseIf i = lastPos Then
                dashboard.Select(cntCount, str(i).ToString.Length)
                dashboard.SelectionBackColor = Color.LightBlue
            End If
            dashboard.AppendText(" ")
            dashboard.Select(dashboard.TextLength - 1, 1)
            dashboard.SelectionBackColor = Color.White
        Next
        dashboard.Select(0, 0)
    End Sub

    Private Sub StopProcess()
        ButtonNext.Enabled = False
        ButtonStart.Enabled = True
        ButtonLoadFile.Enabled = True

        RichTextBoxBlank.Enabled = True
        RichTextBoxCharset.Enabled = True
        RichTextBoxFinal.Enabled = True
        RichTextBoxInit.Enabled = True
        RichTextBoxStatus.Enabled = True
        RichTextBoxString.Enabled = True
    End Sub

    Private Sub NextStep()
        Dim trigger As New Trigger With {
            .input = str(cntPos),
            .status = cntStatus
        }
        If transfer.ContainsKey(trigger) Then
            Dim dest As Destination = transfer(trigger)
            ListBoxTransfer.SelectedIndex = dest.listID
            str(cntPos) = dest.WriteChar
            lastPos = cntPos
            If dest.Motion = "L" Then
                cntPos -= 1
            ElseIf dest.Motion = "R" Then
                cntPos += 1
            End If
            If cntPos < 0 Then
                MessageBox.Show("读写头超过左边界！", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
            End If
            If cntPos >= str.Count Then
                MessageBox.Show("读写头超过右边界！", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
            End If
            cntStatus = dest.ToStatus
            LabelCntStatus.Text = cntStatus
        Else
            MessageBox.Show("找不到对应的转移函数 不接受此字符串", "提示"， MessageBoxButtons.OK, MessageBoxIcon.Information)
            StopProcess()
        End If

        PaintGraph()

        If str(cntPos) = blankChar Then
            hasReachedBlank = True
        End If

        If hasReachedBlank And finalStatus.Contains(cntStatus) Then
            MessageBox.Show("到达中止状态 接受此字符串", "提示"， MessageBoxButtons.OK, MessageBoxIcon.Information)
            StopProcess()
        End If

    End Sub

    Private Sub ParseConfig()

        status.Clear()

        For Each item In RichTextBoxStatus.Text.Split(",")
            status.Add(item, item)
        Next

        charSet.Clear()

        For Each item In RichTextBoxCharset.Text.Split(",")
            charSet.Add(item, item)
        Next

        finalStatus.Clear()

        For Each item In RichTextBoxFinal.Text.Split(",")
            finalStatus.Add(item, item)
        Next

        initStatus = RichTextBoxInit.Text
        blankChar = RichTextBoxBlank.Text

        str.Clear()

        str.Add(blankChar)
        For Each item In RichTextBoxString.Text.Split(",")
            str.Add(item)
        Next
        str.Add(blankChar)

    End Sub

    Private Sub LoadConfig()
        Dim reader As New IO.StreamReader(configPath)

        reader.ReadLine()
        RichTextBoxStatus.Text = reader.ReadLine()


        reader.ReadLine()
        RichTextBoxCharset.Text = reader.ReadLine()


        reader.ReadLine()
        RichTextBoxInit.Text = reader.ReadLine()

        reader.ReadLine()
        RichTextBoxBlank.Text = reader.ReadLine()

        reader.ReadLine()
        RichTextBoxFinal.Text = reader.ReadLine()

        reader.ReadLine()
        RichTextBoxString.Text = reader.ReadLine()

        reader.ReadLine()
        Dim transferConfig As String
        ListBoxTransfer.Items.Clear()
        Dim listCount As Integer = 0
        While True
            transferConfig = reader.ReadLine()
            If transferConfig = "" Then
                Exit While
            End If
            ListBoxTransfer.Items.Add(transferConfig)
            Dim leftExp As String = transferConfig.Split("=")(0)
            Dim rightExp As String = transferConfig.Split("=")(1)
            Dim fromStatus, readChar, toStatus, writeChar, Motion As String
            Dim pos As Integer = leftExp.IndexOf(",")
            fromStatus = leftExp.Substring(2, pos - 2)
            readChar = leftExp.Substring(pos + 1, leftExp.Length - pos - 2)
            Dim posl As Integer = rightExp.IndexOf(",")
            Dim posr As Integer = rightExp.LastIndexOf(",")
            toStatus = rightExp.Substring(1, posl - 1)
            writeChar = rightExp.Substring(posl + 1, posr - posl - 1)
            Motion = rightExp.Substring(posr + 1)
            Motion = Motion.Substring(0, Motion.Length - 1)
            Dim trigger As New Trigger With {
                .input = readChar,
                .status = fromStatus
            }
            Dim dest As New Destination With {
                .listID = listCount
            }
            listCount += 1
            dest.WriteChar = writeChar
            dest.ToStatus = toStatus
            dest.Motion = Motion
            transfer.Add(trigger, dest)
        End While
        reader.Close()
    End Sub

    Private Sub ButtonLoadFile_Click(sender As Object, e As EventArgs) Handles ButtonLoadFile.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            configPath = OpenFileDialog.FileName
            LoadConfig()
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' For test
        'configPath = "D:\Turning.txt"
        'LoadConfig()

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If RichTextBoxBlank.TextLength = 0 Or RichTextBoxCharset.TextLength = 0 Or RichTextBoxInit.TextLength = 0 Or RichTextBoxFinal.TextLength = 0 Or RichTextBoxStatus.TextLength = 0 Or RichTextBoxString.TextLength = 0 Then
            MessageBox.Show("参数不完整！", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        RichTextBoxBlank.Enabled = False
        RichTextBoxCharset.Enabled = False
        RichTextBoxFinal.Enabled = False
        RichTextBoxInit.Enabled = False
        RichTextBoxStatus.Enabled = False
        RichTextBoxString.Enabled = False

        ButtonStart.Enabled = False
        ButtonNext.Enabled = True
        ButtonLoadFile.Enabled = False
        ParseConfig()
        cntPos = 1
        cntStatus = initStatus
        hasReachedBlank = False
        LabelCntStatus.Text = cntStatus
        lastPos = -1

        'Check valid
        For Each i In str
            If i = blankChar Then Continue For
            If Not charSet.Contains(i) Then
                MessageBox.Show("字符串中含有非法字符", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
        Next

        For Each i In finalStatus
            If Not status.Contains(i) Then
                MessageBox.Show("中止状态中含有非法状态", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
        Next

        If Not status.Contains(initStatus) Then
            MessageBox.Show("初始状态不合法", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
            StopProcess()
            Exit Sub
        End If

        For Each i In transfer
            If Not (charSet.Contains(i.Key.input) Or i.Key.input = blankChar) Then
                MessageBox.Show("转移函数中含有非法字符", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
            If Not (charSet.Contains(i.Value.WriteChar) Or i.Value.WriteChar = blankChar) Then
                MessageBox.Show("转移函数中含有非法字符", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
            If Not status.Contains(i.Key.status) Then
                MessageBox.Show("转移函数中含有非法状态", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
            If Not status.Contains(i.Value.ToStatus) Then
                MessageBox.Show("转移函数中含有非法状态", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
            If i.Value.Motion <> "L" And i.Value.Motion <> "R" And i.Value.Motion <> "S" Then
                MessageBox.Show("转移函数中含有非法操作", "错误"， MessageBoxButtons.OK, MessageBoxIcon.Error)
                StopProcess()
                Exit Sub
            End If
        Next

        PaintGraph()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        NextStep()
    End Sub

End Class

Public Class Trigger
    Public status As String
    Public input As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim other As Trigger = CType(obj, Trigger)
        Return status = other.status And input = other.input
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return status.GetHashCode() + input.GetHashCode()
    End Function

End Class

Public Class Destination
    Public ToStatus As String
    Public WriteChar As String
    Public Motion As String
    Public listID As Integer
End Class