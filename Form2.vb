Imports System.Data.OleDb
Public Class FrmMain
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_kuafor.mdb")
    Private Sub Temizle()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Ekle" Then
            baglanti.Open()
            Dim komut As New OleDbCommand("insert into bilgi(musteri_Ad,musteri_Soyad,islem,ucret,Personel) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", baglanti)
            komut.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Kayıt Eklendi", "Kayıt")
            Temizle()
            tablo.Clear()
            Listele()
        End If
        If Button1.Text = "Güncelle" Then
            baglanti.Open()
            Dim komut2 As New OleDbCommand("update bilgi set musteri_ad ='" + TextBox1.Text + "',islem ='" + TextBox3.Text + "',ucret ='" + TextBox4.Text + "',personel ='" + TextBox5.Text + "'where musteri_Soyad='" + TextBox2.Text + "'", baglanti)
            komut2.ExecuteNonQuery()
            baglanti.Close()
            MessageBox.Show("Kayıt Güncellendi", "Kayıt")
            Temizle()
            tablo.Clear()
            Listele()
            Button1.Text = "Ekle"
        End If

    End Sub
    Dim tablo As New DataTable
    Private Sub Listele()
        baglanti.Open()
        Dim Adtr As New OleDbDataAdapter("select*from bilgi", baglanti)
        Adtr.Fill(tablo)
        DataGridView1.DataSource = tablo
        baglanti.Close()

    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        baglanti.Open()
        Dim komut As New OleDbCommand("delete from bilgi where musteri_Soyad='" + DataGridView1.CurrentRow.Cells("musteri_Soyad").Value.ToString() + "'", baglanti)
        komut.ExecuteNonQuery()
        baglanti.Close()
        tablo.Clear()
        Listele()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        baglanti.Open()
        Dim adtr As New OleDbDataAdapter("select*from bilgi where musteri_Ad like '" + TextBox6.Text + "%'", baglanti)
        Dim tablo2 As New DataTable
        adtr.Fill(tablo2)
        DataGridView1.DataSource = tablo2
        baglanti.Close()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells("musteri_Ad").Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells("musteri_Soyad").Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells("islem").Value.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells("ucret").Value.ToString
        TextBox5.Text = DataGridView1.CurrentRow.Cells("personel").Value.ToString
        Button1.Text = "Güncelle"
    End Sub
End Class