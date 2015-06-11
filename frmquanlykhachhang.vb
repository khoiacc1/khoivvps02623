Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlykhachhang
    Dim Database As New DataTable
    Dim chuoiconnect As String = "workstation id=ps02623.mssql.somee.com;packet size=4096;user id=khoivvps02623_SQLLogin_1;pwd=kcwc6omhvq;data source=ps02623.mssql.somee.com;persist security info=False;initial catalog=ps02623"
    Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
    Private Sub btnthemkh_Click(sender As Object, e As EventArgs) Handles btnthemkh.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into Khachhang values (@Makhachhang, @Tenkhachhang, @Diachi, @SoDT)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@Makhachhang", txtmakh.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Tenkhachhang", txttenkh.Text)
            ExecuteQuery1.Parameters.AddWithValue("@Diachi", txtdiachikh.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SoDT", txtsodtkh.Text)

            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
            txtmakh.Clear()
            txttenkh.Clear()
            txtdiachikh.Clear()
            txtsodtkh.Clear()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from Khachhang", connect)
        Database.Clear()

        Query3.Fill(Database)
        DataGridView2.DataSource = Database.DefaultView
    End Sub

    Private Sub frmquanlykhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Khachhang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(Database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView2.DataSource = Database.DefaultView

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim index As Integer = DataGridView2.CurrentCell.RowIndex
        txtmakh.Text = DataGridView2.Item(0, index).Value
        txttenkh.Text = DataGridView2.Item(1, index).Value
        txtdiachikh.Text = DataGridView2.Item(2, index).Value
        txtsodtkh.Text = DataGridView2.Item(3, index).Value
    End Sub

    Private Sub btnsuakh_Click(sender As Object, e As EventArgs) Handles btnsuakh.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update Khachhang Set Tenkhachhang = @Tenkhachhang, SoDT = @SoDT , Diachi = @Diachi where Makhachhang = @Makhachhang"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@Makhachhang", txtmakh.Text)
            com.Parameters.AddWithValue("@Tenkhachhang", txttenkh.Text)
            com.Parameters.AddWithValue("@Diachi", txtdiachikh.Text)
            com.Parameters.AddWithValue("@SoDT", txtsodtkh.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        Database.Clear()
        DataGridView2.DataSource = Database
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from Khachhang", connect)

        connect.Open()
        Query1.Fill(Database)
        DataGridView2.DataSource = Database.DefaultView
    End Sub

    Private Sub btnxoakh_Click(sender As Object, e As EventArgs) Handles btnxoakh.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from Khachhang Where Makhachhang = @Makhachhang"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@Makhachhang", txtmakh.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        Database.Clear()
        DataGridView2.DataSource = Database
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnlamsachkh_Click(sender As Object, e As EventArgs) Handles btnlamsachkh.Click
        txtdiachikh.Clear()
        txtmakh.Clear()
        txtsodtkh.Clear()
        txttenkh.Clear()
    End Sub

    Private Sub btntimkh_Click(sender As Object, e As EventArgs) Handles btntimkh.Click
        ' Tạo đối tượng kết nối tới DB Online
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Kiểm tra DataGridView đã có dữ liệu chưa
        If DataGridView2.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            Database.Clear()
        End If
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select * from Khachhang Where Makhachhang Like N'%" & txttimkiemkh.Text & "%' or Tenkhachhang Like N'%" & txttimkiemkh.Text & "%' or Diachi Like N'%" & txttimkiemkh.Text & "%' or SoDT Like N'%" & txttimkiemkh.Text & "%'", connect)
        Try
            connect.Open()
            Query1.Fill(Database)
            If Database.Rows.Count > 0 Then
                DataGridView2.DataSource = Database.DefaultView
            Else
                MessageBox.Show("Không tìm thấy")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function Query1() As Object
        Throw New NotImplementedException
    End Function

End Class