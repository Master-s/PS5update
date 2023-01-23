<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ps5update = New System.Windows.Forms.Button()
        Me.bFolderPS5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(73, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox2.Size = New System.Drawing.Size(105, 23)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "1337"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(74, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 23)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "IP Here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PS5 IP:"
        '
        'ps5update
        '
        Me.ps5update.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ps5update.Location = New System.Drawing.Point(74, 68)
        Me.ps5update.Name = "ps5update"
        Me.ps5update.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ps5update.Size = New System.Drawing.Size(105, 23)
        Me.ps5update.TabIndex = 99
        Me.ps5update.Text = "Disable Upadate"
        Me.ps5update.UseVisualStyleBackColor = True
        '
        'bFolderPS5
        '
        Me.bFolderPS5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bFolderPS5.Location = New System.Drawing.Point(120, 95)
        Me.bFolderPS5.Name = "bFolderPS5"
        Me.bFolderPS5.Size = New System.Drawing.Size(105, 23)
        Me.bFolderPS5.TabIndex = 97
        Me.bFolderPS5.Text = "Open Folder PS5"
        Me.bFolderPS5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(9, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Open Folder upadate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"300", "320", "403", "450", "451", "650"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 68)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(59, 21)
        Me.ComboBox1.TabIndex = 101
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PS5update.My.Resources.Resources._10_1
        Me.PictureBox1.Location = New System.Drawing.Point(184, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(251, 152)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ps5update)
        Me.Controls.Add(Me.bFolderPS5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS5update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents ps5update As Button
    Private WithEvents bFolderPS5 As Button
    Private WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
