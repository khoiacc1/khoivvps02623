<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlykhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmquanlykhachhang))
        Me.txttimkiemkh = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnxoakh = New System.Windows.Forms.Button()
        Me.btnsuakh = New System.Windows.Forms.Button()
        Me.btnlamsachkh = New System.Windows.Forms.Button()
        Me.btnthemkh = New System.Windows.Forms.Button()
        Me.txtsodtkh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdiachikh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btntimkh = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimkiemkh
        '
        Me.txttimkiemkh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimkiemkh.Location = New System.Drawing.Point(293, 12)
        Me.txttimkiemkh.Multiline = True
        Me.txttimkiemkh.Name = "txttimkiemkh"
        Me.txttimkiemkh.Size = New System.Drawing.Size(187, 36)
        Me.txttimkiemkh.TabIndex = 12
        Me.txttimkiemkh.Text = "Tìm kiếm tại đây"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnxoakh)
        Me.GroupBox1.Controls.Add(Me.btnsuakh)
        Me.GroupBox1.Controls.Add(Me.btnlamsachkh)
        Me.GroupBox1.Controls.Add(Me.btnthemkh)
        Me.GroupBox1.Controls.Add(Me.txtsodtkh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdiachikh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttenkh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmakh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 290)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin nhân viên"
        '
        'btnxoakh
        '
        Me.btnxoakh.Image = CType(resources.GetObject("btnxoakh.Image"), System.Drawing.Image)
        Me.btnxoakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoakh.Location = New System.Drawing.Point(124, 176)
        Me.btnxoakh.Name = "btnxoakh"
        Me.btnxoakh.Size = New System.Drawing.Size(96, 47)
        Me.btnxoakh.TabIndex = 7
        Me.btnxoakh.Text = "Xóa"
        Me.btnxoakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoakh.UseVisualStyleBackColor = True
        '
        'btnsuakh
        '
        Me.btnsuakh.Image = Global.khoivvps02623.My.Resources.Resources.edit_icon
        Me.btnsuakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsuakh.Location = New System.Drawing.Point(9, 229)
        Me.btnsuakh.Name = "btnsuakh"
        Me.btnsuakh.Size = New System.Drawing.Size(96, 47)
        Me.btnsuakh.TabIndex = 8
        Me.btnsuakh.Text = "Sửa"
        Me.btnsuakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsuakh.UseVisualStyleBackColor = True
        '
        'btnlamsachkh
        '
        Me.btnlamsachkh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlamsachkh.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon
        Me.btnlamsachkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlamsachkh.Location = New System.Drawing.Point(123, 229)
        Me.btnlamsachkh.Name = "btnlamsachkh"
        Me.btnlamsachkh.Size = New System.Drawing.Size(97, 47)
        Me.btnlamsachkh.TabIndex = 9
        Me.btnlamsachkh.Text = "Clear"
        Me.btnlamsachkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlamsachkh.UseVisualStyleBackColor = True
        '
        'btnthemkh
        '
        Me.btnthemkh.Image = Global.khoivvps02623.My.Resources.Resources.Actions_edit_clear_icon1
        Me.btnthemkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthemkh.Location = New System.Drawing.Point(9, 176)
        Me.btnthemkh.Name = "btnthemkh"
        Me.btnthemkh.Size = New System.Drawing.Size(96, 47)
        Me.btnthemkh.TabIndex = 6
        Me.btnthemkh.Text = "Thêm"
        Me.btnthemkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthemkh.UseVisualStyleBackColor = True
        '
        'txtsodtkh
        '
        Me.txtsodtkh.Location = New System.Drawing.Point(116, 145)
        Me.txtsodtkh.Multiline = True
        Me.txtsodtkh.Name = "txtsodtkh"
        Me.txtsodtkh.Size = New System.Drawing.Size(130, 25)
        Me.txtsodtkh.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số ĐT:"
        '
        'txtdiachikh
        '
        Me.txtdiachikh.Location = New System.Drawing.Point(116, 97)
        Me.txtdiachikh.Multiline = True
        Me.txtdiachikh.Name = "txtdiachikh"
        Me.txtdiachikh.Size = New System.Drawing.Size(238, 42)
        Me.txtdiachikh.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Địa chỉ:"
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(116, 66)
        Me.txttenkh.Multiline = True
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(141, 25)
        Me.txttenkh.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên khách hàng:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(116, 35)
        Me.txtmakh.Multiline = True
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(118, 25)
        Me.txtmakh.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(378, 67)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(470, 280)
        Me.DataGridView2.TabIndex = 14
        '
        'btntimkh
        '
        Me.btntimkh.Image = Global.khoivvps02623.My.Resources.Resources.Search_icon
        Me.btntimkh.Location = New System.Drawing.Point(486, 12)
        Me.btntimkh.Name = "btntimkh"
        Me.btntimkh.Size = New System.Drawing.Size(36, 36)
        Me.btntimkh.TabIndex = 13
        Me.btntimkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntimkh.UseVisualStyleBackColor = True
        '
        'frmquanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 372)
        Me.Controls.Add(Me.txttimkiemkh)
        Me.Controls.Add(Me.btntimkh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmquanlykhachhang"
        Me.Text = "Quản lý khách hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimkiemkh As System.Windows.Forms.TextBox
    Friend WithEvents btntimkh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnxoakh As System.Windows.Forms.Button
    Friend WithEvents btnsuakh As System.Windows.Forms.Button
    Friend WithEvents btnlamsachkh As System.Windows.Forms.Button
    Friend WithEvents btnthemkh As System.Windows.Forms.Button
    Friend WithEvents txtdiachikh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtsodtkh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
