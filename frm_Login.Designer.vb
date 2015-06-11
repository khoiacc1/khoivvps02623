<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.ptbdangnhap = New System.Windows.Forms.PictureBox()
        Me.lbldangnhap = New System.Windows.Forms.Label()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.txttaikhoan = New System.Windows.Forms.TextBox()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.ptbdangnhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbdangnhap
        '
        Me.ptbdangnhap.Image = CType(resources.GetObject("ptbdangnhap.Image"), System.Drawing.Image)
        Me.ptbdangnhap.Location = New System.Drawing.Point(12, 29)
        Me.ptbdangnhap.Name = "ptbdangnhap"
        Me.ptbdangnhap.Size = New System.Drawing.Size(131, 128)
        Me.ptbdangnhap.TabIndex = 0
        Me.ptbdangnhap.TabStop = False
        '
        'lbldangnhap
        '
        Me.lbldangnhap.AutoSize = True
        Me.lbldangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldangnhap.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbldangnhap.Location = New System.Drawing.Point(161, 9)
        Me.lbldangnhap.Name = "lbldangnhap"
        Me.lbldangnhap.Size = New System.Drawing.Size(138, 29)
        Me.lbldangnhap.TabIndex = 1
        Me.lbldangnhap.Text = "Đăng nhập"
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.AutoSize = True
        Me.lbltaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaikhoan.Location = New System.Drawing.Point(160, 64)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(68, 13)
        Me.lbltaikhoan.TabIndex = 2
        Me.lbltaikhoan.Text = "Tài khoản:"
        '
        'txttaikhoan
        '
        Me.txttaikhoan.Location = New System.Drawing.Point(229, 58)
        Me.txttaikhoan.Multiline = True
        Me.txttaikhoan.Name = "txttaikhoan"
        Me.txttaikhoan.Size = New System.Drawing.Size(151, 28)
        Me.txttaikhoan.TabIndex = 1
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatkhau.Location = New System.Drawing.Point(160, 98)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(64, 13)
        Me.lblmatkhau.TabIndex = 2
        Me.lblmatkhau.Text = "Mật khẩu:"
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(229, 92)
        Me.txtmatkhau.Multiline = True
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(151, 28)
        Me.txtmatkhau.TabIndex = 2
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(202, 148)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(86, 31)
        Me.btndangnhap.TabIndex = 3
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(294, 148)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(86, 31)
        Me.btnhuy.TabIndex = 4
        Me.btnhuy.Text = "Hủy "
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(229, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Ghi nhớ tài khoản"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frm_Login
        '
        Me.AcceptButton = Me.btndangnhap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(445, 210)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.txttaikhoan)
        Me.Controls.Add(Me.lbltaikhoan)
        Me.Controls.Add(Me.lbldangnhap)
        Me.Controls.Add(Me.ptbdangnhap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ptbdangnhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbdangnhap As System.Windows.Forms.PictureBox
    Friend WithEvents lbldangnhap As System.Windows.Forms.Label
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents txttaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
