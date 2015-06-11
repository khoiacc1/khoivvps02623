<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsanpham))
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnlamsach = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtchitietsp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btntim = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimkiem
        '
        Me.txttimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimkiem.Location = New System.Drawing.Point(442, 18)
        Me.txttimkiem.Multiline = True
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(187, 36)
        Me.txttimkiem.TabIndex = 12
        Me.txttimkiem.Text = "Tìm kiếm tại đây"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Controls.Add(Me.btnlamsach)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.txtmaloai)
        Me.GroupBox1.Controls.Add(Me.txtdongia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtchitietsp)
        Me.GroupBox1.Controls.Add(Me.txttensp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtsoluong)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmasp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 381)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin nhân viên"
        '
        'btnxoa
        '
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(121, 246)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(96, 47)
        Me.btnxoa.TabIndex = 7
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Image = Global.khoivvps02623.My.Resources.Resources.edit_icon
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsua.Location = New System.Drawing.Point(6, 299)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(96, 47)
        Me.btnsua.TabIndex = 8
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnlamsach
        '
        Me.btnlamsach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlamsach.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon
        Me.btnlamsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlamsach.Location = New System.Drawing.Point(120, 299)
        Me.btnlamsach.Name = "btnlamsach"
        Me.btnlamsach.Size = New System.Drawing.Size(97, 47)
        Me.btnlamsach.TabIndex = 9
        Me.btnlamsach.Text = "Clear"
        Me.btnlamsach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlamsach.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon1
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.Location = New System.Drawing.Point(6, 246)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(96, 47)
        Me.btnthem.TabIndex = 6
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(104, 212)
        Me.txtmaloai.Multiline = True
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(118, 25)
        Me.txtmaloai.TabIndex = 5
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(102, 97)
        Me.txtdongia.Multiline = True
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(126, 25)
        Me.txtdongia.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mã loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Đơn giá (VNĐ):"
        '
        'txtchitietsp
        '
        Me.txtchitietsp.Location = New System.Drawing.Point(102, 159)
        Me.txtchitietsp.Multiline = True
        Me.txtchitietsp.Name = "txtchitietsp"
        Me.txtchitietsp.Size = New System.Drawing.Size(315, 47)
        Me.txtchitietsp.TabIndex = 4
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(102, 66)
        Me.txttensp.Multiline = True
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(142, 25)
        Me.txttensp.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Chi tiết SP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm:"
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(102, 128)
        Me.txtsoluong.Multiline = True
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(79, 25)
        Me.txtsoluong.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số lượng:"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(102, 35)
        Me.txtmasp.Multiline = True
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(118, 25)
        Me.txtmasp.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(442, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(707, 369)
        Me.DataGridView1.TabIndex = 14
        '
        'btntim
        '
        Me.btntim.Image = Global.khoivvps02623.My.Resources.Resources.Search_icon
        Me.btntim.Location = New System.Drawing.Point(635, 18)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(36, 36)
        Me.btntim.TabIndex = 13
        Me.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntim.UseVisualStyleBackColor = True
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 444)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsanpham"
        Me.Text = "Quản lý sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnlamsach As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtchitietsp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
