<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.RichTextBoxStatus = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBoxCharset = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBoxFinal = New System.Windows.Forms.RichTextBox()
        Me.ListBoxTransfer = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.RichTextBoxString = New System.Windows.Forms.RichTextBox()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonLoadFile = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.dashboard = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxInit = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxBlank = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCntStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBoxStatus
        '
        Me.RichTextBoxStatus.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxStatus.Location = New System.Drawing.Point(118, 99)
        Me.RichTextBoxStatus.Name = "RichTextBoxStatus"
        Me.RichTextBoxStatus.Size = New System.Drawing.Size(589, 60)
        Me.RichTextBoxStatus.TabIndex = 0
        Me.RichTextBoxStatus.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "状态集"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "字符集"
        '
        'RichTextBoxCharset
        '
        Me.RichTextBoxCharset.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxCharset.Location = New System.Drawing.Point(118, 183)
        Me.RichTextBoxCharset.Name = "RichTextBoxCharset"
        Me.RichTextBoxCharset.Size = New System.Drawing.Size(589, 60)
        Me.RichTextBoxCharset.TabIndex = 3
        Me.RichTextBoxCharset.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "终止状态集"
        '
        'RichTextBoxFinal
        '
        Me.RichTextBoxFinal.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxFinal.Location = New System.Drawing.Point(118, 265)
        Me.RichTextBoxFinal.Name = "RichTextBoxFinal"
        Me.RichTextBoxFinal.Size = New System.Drawing.Size(589, 60)
        Me.RichTextBoxFinal.TabIndex = 9
        Me.RichTextBoxFinal.Text = ""
        '
        'ListBoxTransfer
        '
        Me.ListBoxTransfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxTransfer.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBoxTransfer.FormattingEnabled = True
        Me.ListBoxTransfer.ItemHeight = 22
        Me.ListBoxTransfer.Location = New System.Drawing.Point(725, 12)
        Me.ListBoxTransfer.Name = "ListBoxTransfer"
        Me.ListBoxTransfer.ScrollAlwaysVisible = True
        Me.ListBoxTransfer.Size = New System.Drawing.Size(219, 554)
        Me.ListBoxTransfer.TabIndex = 10
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'RichTextBoxString
        '
        Me.RichTextBoxString.Font = New System.Drawing.Font("等线", 16.0!)
        Me.RichTextBoxString.Location = New System.Drawing.Point(118, 348)
        Me.RichTextBoxString.Name = "RichTextBoxString"
        Me.RichTextBoxString.Size = New System.Drawing.Size(589, 66)
        Me.RichTextBoxString.TabIndex = 11
        Me.RichTextBoxString.Text = ""
        '
        'ButtonNext
        '
        Me.ButtonNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNext.Enabled = False
        Me.ButtonNext.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(850, 594)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(94, 51)
        Me.ButtonNext.TabIndex = 12
        Me.ButtonNext.Text = "下一步"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "读取字符串"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "空白符"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "初始状态"
        '
        'ButtonLoadFile
        '
        Me.ButtonLoadFile.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonLoadFile.Location = New System.Drawing.Point(610, 24)
        Me.ButtonLoadFile.Name = "ButtonLoadFile"
        Me.ButtonLoadFile.Size = New System.Drawing.Size(97, 51)
        Me.ButtonLoadFile.TabIndex = 19
        Me.ButtonLoadFile.Text = "加载配置"
        Me.ButtonLoadFile.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonStart.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(725, 594)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(94, 51)
        Me.ButtonStart.TabIndex = 20
        Me.ButtonStart.Text = "开始执行"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.dashboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dashboard.Font = New System.Drawing.Font("等线", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dashboard.Location = New System.Drawing.Point(12, 434)
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Size = New System.Drawing.Size(695, 216)
        Me.dashboard.TabIndex = 21
        Me.dashboard.Text = ""
        '
        'RichTextBoxInit
        '
        Me.RichTextBoxInit.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxInit.Location = New System.Drawing.Point(118, 34)
        Me.RichTextBoxInit.Name = "RichTextBoxInit"
        Me.RichTextBoxInit.Size = New System.Drawing.Size(70, 39)
        Me.RichTextBoxInit.TabIndex = 22
        Me.RichTextBoxInit.Text = ""
        '
        'RichTextBoxBlank
        '
        Me.RichTextBoxBlank.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBoxBlank.Location = New System.Drawing.Point(304, 34)
        Me.RichTextBoxBlank.Name = "RichTextBoxBlank"
        Me.RichTextBoxBlank.Size = New System.Drawing.Size(70, 39)
        Me.RichTextBoxBlank.TabIndex = 23
        Me.RichTextBoxBlank.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 19)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "当前状态："
        '
        'LabelCntStatus
        '
        Me.LabelCntStatus.AutoSize = True
        Me.LabelCntStatus.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelCntStatus.Location = New System.Drawing.Point(508, 40)
        Me.LabelCntStatus.Name = "LabelCntStatus"
        Me.LabelCntStatus.Size = New System.Drawing.Size(47, 19)
        Me.LabelCntStatus.TabIndex = 25
        Me.LabelCntStatus.Text = "Stop"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 666)
        Me.Controls.Add(Me.LabelCntStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBoxBlank)
        Me.Controls.Add(Me.RichTextBoxInit)
        Me.Controls.Add(Me.dashboard)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonLoadFile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.RichTextBoxString)
        Me.Controls.Add(Me.ListBoxTransfer)
        Me.Controls.Add(Me.RichTextBoxFinal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RichTextBoxCharset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBoxStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Universal Turning Machine Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBoxStatus As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBoxCharset As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBoxFinal As RichTextBox
    Friend WithEvents ListBoxTransfer As ListBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents RichTextBoxString As RichTextBox
    Friend WithEvents ButtonNext As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonLoadFile As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents dashboard As RichTextBox
    Friend WithEvents RichTextBoxInit As RichTextBox
    Friend WithEvents RichTextBoxBlank As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelCntStatus As Label
End Class
