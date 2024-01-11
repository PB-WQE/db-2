Imports System.Data.OleDb


Public Class Form1
    ' data connecton = "
    'set up in the PUBLIC  area so they are available throughout
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Dim Rindex As Integer
    Dim CompId As Integer
    Private bitmap As Bitmap

    Private Sub viewer()
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("Select * from tblDetails", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        conn.Close()
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 50
        DataGridView1.Columns(7).Width = 50
    End Sub
    Public Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Rindex = e.RowIndex
        Dim selectedrow As DataGridViewRow = DataGridView1.Rows(Rindex)
        txtId.Text = selectedrow.Cells(0).Value.ToString
        CompId = selectedrow.Cells(0).Value
        txtCompType.Text = selectedrow.Cells(1).Value.ToString
        txtCompName.Text = selectedrow.Cells(2).Value.ToString
        txtEv1.Text = selectedrow.Cells(3).Value.ToString
        txtEv2.Text = selectedrow.Cells(4).Value.ToString
        txtEv3.Text = selectedrow.Cells(5).Value.ToString
        txtEv4.Text = selectedrow.Cells(6).Value.ToString
        txtEv5.Text = selectedrow.Cells(7).Value.ToString

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\repos\db2\CompetitionDB.accdb"
        viewer()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strsql As String
        strsql = "Insert into tblDetails ( CompetitorType, CompetitorName, Ev1,Ev2,Ev3,Ev4,Ev5) values (@type, @name, @Ev1, @ev2, @ev3, @ev4, @ev5);"
        Dim cmdAppend As New OleDbCommand(strsql, conn)

        cmdAppend.Parameters.AddWithValue("@type", txtCompType.Text)
        cmdAppend.Parameters.AddWithValue("@name", txtCompName.Text)
        cmdAppend.Parameters.AddWithValue("@Ev1", txtEv1.Text)
        cmdAppend.Parameters.AddWithValue("@Ev2", txtEv2.Text)
        cmdAppend.Parameters.AddWithValue("@Ev3", txtEv3.Text)
        cmdAppend.Parameters.AddWithValue("@Ev4", txtEv4.Text)
        cmdAppend.Parameters.AddWithValue("@Ev5", txtEv5.Text)


        conn.Open()
        cmdAppend.ExecuteNonQuery()
        conn.Close()
        viewer()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'should have cliked on an existing row to copy details to the text boxes.
        Dim strsql As String
        strsql = "update tblDetails set Ev1=@Ev1, Ev2=@Ev2, Ev3 =@Ev3, Ev4=@Ev4,Ev5= @Ev5  where CompetitorID = @Id ;"
        Dim cmdUpdate As New OleDbCommand(strsql, conn)
        cmdUpdate.Parameters.AddWithValue("@Ev1", Me.txtEv1.Text)
        cmdUpdate.Parameters.AddWithValue("@Ev2", Me.txtEv2.Text)
        cmdUpdate.Parameters.AddWithValue("@Ev3", Me.txtEv3.Text)
        cmdUpdate.Parameters.AddWithValue("@Ev4", Me.txtEv4.Text)
        cmdUpdate.Parameters.AddWithValue("@Ev5", Me.txtEv5.Text)
        cmdUpdate.Parameters.AddWithValue("@Id", Me.txtId.Text)
        conn.Open()
        cmdUpdate.ExecuteNonQuery()
        Debug.Print(CompId)
        conn.Close()
        viewer()
    End Sub



End Class
