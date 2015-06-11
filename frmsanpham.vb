Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmsanpham
    Dim Database As New DataTable
    Dim chuoiconnect As String = "workstation id=ps02623.mssql.somee.com;packet size=4096;user id=khoivvps02623_SQLLogin_1;pwd=kcwc6omhvq;data source=ps02623.mssql.somee.com;persist security info=False;initial catalog=ps02623"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Sanpham", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(Database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = Database.DefaultView
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Sanpham values (@MaSP, @TenSP, @Dongia, @Soluong, @ChitietSP, @Loaisanpham_Maloai)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenSP", txttensp.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Dongia", txtdongia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Soluong", txtsoluong.Text)
            ExecuteQuery1.Parameters.AddWithValue("@ChitietSP", txtchitietsp.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Loaisanpham_Maloai", txtmaloai.Text)

            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
            txtmasp.Clear()
            txttensp.Clear()
            txtdongia.Clear()
            txtsoluong.Clear()
            txtchitietsp.Clear()
            txtmaloai.Clear()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Sanpham", connect)
        Database.Clear()

        Query3.Fill(Database)
        DataGridView1.DataSource = Database.DefaultView
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from Sanpham Where MaSP = @MaSP"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        Database.Clear()
        DataGridView1.DataSource = Database
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmasp.Text = DataGridView1.Item(0, index).Value
        txttensp.Text = DataGridView1.Item(1, index).Value
        txtdongia.Text = DataGridView1.Item(2, index).Value
        txtsoluong.Text = DataGridView1.Item(3, index).Value
        txtchitietsp.Text = DataGridView1.Item(4, index).Value
        txtmaloai.Text = DataGridView1.Item(5, index).Value
    End Sub

    Private Sub btnlamsach_Click(sender As Object, e As EventArgs) Handles btnlamsach.Click
        txtmasp.Clear()
        txttensp.Clear()
        txtdongia.Clear()
        txtsoluong.Clear()
        txtchitietsp.Clear()
        txtmaloai.Clear()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update Sanpham Set TenSP = @TenSP, Dongia = @Dongia, Soluong = @Soluong, ChitietSP = @ChitietSP, Loaisanpham_Maloai = @Loaisanpham_Maloai where MaSP = @MaSP"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@Dongia", txtdongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtsoluong.Text)
            com.Parameters.AddWithValue("@ChitietSP", txtchitietsp.Text)
            com.Parameters.AddWithValue("@Loaisanpham_Maloai", txtmaloai.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Database.Clear()
        DataGridView1.DataSource = Database
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Sanpham", connect)

        connect.Open()
        Query1.Fill(Database)
        DataGridView1.DataSource = Database.DefaultView
    End Sub

    Private Sub txttimkiem_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged

    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        ' Tạo đối tượng kết nối tới DB Online
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Kiểm tra DataGridView đã có dữ liệu chưa
        If DataGridView1.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            Database.Clear()
        End If
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select * from Sanpham Where MaSP Like N'%" & txttimkiem.Text & "%' or TensP Like N'%" & txttimkiem.Text & "%' or Dongia Like N'%" & txttimkiem.Text & "%' or Soluong Like N'%" & txttimkiem.Text & "%' or ChitietSP Like N'%" & txttimkiem.Text & "%' or Loaisanpham_Maloai Like N'%" & txttimkiem.Text & "%'", connect)
        Try
            connect.Open()
            Query1.Fill(Database)
            If Database.Rows.Count > 0 Then
                DataGridView1.DataSource = Database.DefaultView
            Else
                MessageBox.Show("Không tìm thấy")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class