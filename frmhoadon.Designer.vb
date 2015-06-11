<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhoadon))
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnchitiethd = New System.Windows.Forms.Button()
        Me.txtngaylaphd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttongtienhd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmanv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btntim = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnlamsach = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
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
        Me.txttimkiem.TabIndex = 12
        Me.txttimkiem.Text = "Tìm kiếm tại đây"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnchitiethd)
        Me.GroupBox1.Controls.Add(Me.txtngaylaphd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttongtienhd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmanv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmahd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 140)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin nhân viên"
        '
        'btnchitiethd
        '
        Me.btnchitiethd.Location = New System.Drawing.Point(262, 100)
        Me.btnchitiethd.Name = "btnchitiethd"
        Me.btnchitiethd.Size = New System.Drawing.Size(138, 34)
        Me.btnchitiethd.TabIndex = 6
        Me.btnchitiethd.Text = "Chi tiết hóa đơn"
        Me.btnchitiethd.UseVisualStyleBackColor = True
        '
        'txtngaylaphd
        '
        Me.txtngaylaphd.Location = New System.Drawing.Point(102, 97)
        Me.txtngaylaphd.Multiline = True
        Me.txtngaylaphd.Name = "txtngaylaphd"
        Me.txtngaylaphd.Size = New System.Drawing.Size(118, 25)
        Me.txtngaylaphd.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày lập:"
        '
        'txttongtienhd
        '
        Me.txttongtienhd.Location = New System.Drawing.Point(102, 66)
        Me.txttongtienhd.Multiline = True
        Me.txttongtienhd.Name = "txttongtienhd"
        Me.txttongtienhd.Size = New System.Drawing.Size(118, 25)
        Me.txttongtienhd.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tổng tiền:"
        '
        'txtmanv
        '
        Me.txtmanv.Location = New System.Drawing.Point(355, 69)
        Me.txtmanv.Multiline = True
        Me.txtmanv.Name = "txtmanv"
        Me.txtmanv.Size = New System.Drawing.Size(118, 25)
        Me.txtmanv.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã nhân viên:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(355, 38)
        Me.txtmakh.Multiline = True
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(118, 25)
        Me.txtmakh.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(259, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mã khách hàng:"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(102, 35)
        Me.txtmahd.Multiline = True
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(118, 25)
        Me.txtmahd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn:"
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
        Me.DataGridView1.TabIndex = 14
        '
        'btntim
        '
        Me.btntim.Image = Global.khoivvps02623.My.Resources.Resources.Search_icon
        Me.btntim.Location = New System.Drawing.Point(792, 12)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(36, 36)
        Me.btntim.TabIndex = 13
        Me.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntim.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(599, 315)
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
        Me.btnsua.Location = New System.Drawing.Point(497, 393)
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
        Me.btnlamsach.Location = New System.Drawing.Point(599, 393)
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
        Me.btnthem.Location = New System.Drawing.Point(497, 315)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(96, 47)
        Me.btnthem.TabIndex = 6
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 455)
        Me.Controls.Add(Me.btnlamsach)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa đơn khách hàng"
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
    Friend WithEvents txtngaylaphd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttongtienhd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmanv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnchitiethd As System.Windows.Forms.Button
End Class
