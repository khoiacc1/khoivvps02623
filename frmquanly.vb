Public Class frmquanly

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QuảnLýNhânSựToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânSựToolStripMenuItem.Click
        frmquanlynhanvien.Show()
    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        frmquanlykhachhang.Show()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmloaisanpham.Show()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmsanpham.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmhoadon.Show()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Module1.ExitApp()
    End Sub
End Class