<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchitiethoadon))
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.btntim = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmacthd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnlamsach = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimkiem
        '
        Me.txttimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimkiem.Location = New System.Drawing.Point(599, 12)
        Me.txttimkiem.Multiline = True
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(187, 36)
        Me.txttimkiem.TabIndex = 20
        Me.txttimkiem.Text = "Tìm kiếm tại đây"
        '
        'btntim
        '
        Me.btntim.Image = Global.khoivvps02623.My.Resources.Resources.Search_icon
        Me.btntim.Location = New System.Drawing.Point(792, 12)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(36, 36)
        Me.btntim.TabIndex = 21
        Me.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntim.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmasp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtmacthd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmahd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsoluong)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 114)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin nhân viên"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(355, 35)
        Me.txtmasp.Multiline = True
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(118, 25)
        Me.txtmasp.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã sản phẩm:"
        '
        'txtmacthd
        '
        Me.txtmacthd.Location = New System.Drawing.Point(102, 66)
        Me.txtmacthd.Multiline = True
        Me.txtmacthd.Name = "txtmacthd"
        Me.txtmacthd.Size = New System.Drawing.Size(118, 25)
        Me.txtmacthd.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã CTHD:"
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(102, 35)
        Me.txtsoluong.Multiline = True
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(118, 25)
        Me.txtsoluong.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số lượng:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(816, 241)
        Me.DataGridView1.TabIndex = 22
        '
        'btnlamsach
        '
        Me.btnlamsach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlamsach.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon
        Me.btnlamsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlamsach.Location = New System.Drawing.Point(599, 374)
        Me.btnlamsach.Name = "btnlamsach"
        Me.btnlamsach.Size = New System.Drawing.Size(97, 47)
        Me.btnlamsach.TabIndex = 18
        Me.btnlamsach.Text = "Clear"
        Me.btnlamsach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlamsach.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Image = Global.khoivvps02623.My.Resources.Resources.edit_icon
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.Location = New System.Drawing.Point(497, 374)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(96, 47)
        Me.btnsua.TabIndex = 17
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(599, 315)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(96, 47)
        Me.btnxoa.TabIndex = 16
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon1
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(497, 315)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(96, 47)
        Me.btnthem.TabIndex = 15
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã hóa đơn:"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(355, 66)
        Me.txtmahd.Multiline = True
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(118, 25)
        Me.txtmahd.TabIndex = 3
        '
        'frmchitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 431)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnlamsach)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Name = "frmchitiethoadon"
        Me.Text = "Chi tiết hóa đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmacthd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnlamsach As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
