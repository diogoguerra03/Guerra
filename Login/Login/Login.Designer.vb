<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnView = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImgPass = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'BtnView
        '
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnView.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnView.ImageList = Me.ImgPass
        Me.BtnView.Location = New System.Drawing.Point(445, 98)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(26, 20)
        Me.BtnView.TabIndex = 11
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(361, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 27)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(185, 98)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(254, 20)
        Me.TxtPass.TabIndex = 9
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(185, 39)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(254, 20)
        Me.TxtUser.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Palavra-passe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(23, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Utilizador:"
        '
        'ImgPass
        '
        Me.ImgPass.ImageStream = CType(resources.GetObject("ImgPass.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgPass.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgPass.Images.SetKeyName(0, "eye.png")
        Me.ImgPass.Images.SetKeyName(1, "pass.png")
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(491, 193)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnView As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ImgPass As ImageList
End Class
