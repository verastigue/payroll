Imports MySql.Data.MySqlClient

Module Database
    Private connection As New MySqlConnection
    Private command As New MySqlCommand

    Sub openConnection()
        Try
            connection.ConnectionString = "server=localhost;user=root;password=;database=payroll_schema"
            connection.Open()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    'CREATE, UPDATE, DELETE
    Sub executeQuery(sql As String)
        Try
            openConnection()
            command = New MySqlCommand(sql, connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully")
        Catch ex As Exception
            MessageBox.Show("Error executing data: " & ex.Message)

        Finally
            closeConnection()
        End Try
    End Sub

    'READ DATA TABLE
    Function getData(sql As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            openConnection()
            command = New MySqlCommand(sql, connection)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dataTable)
        Catch ex As Exception
            Console.WriteLine("Error reading data: " & ex.Message)
        Finally
            closeConnection()
        End Try
        Return dataTable
    End Function

    'COUNTING
    Function countData(sql As String) As Integer
        Dim counts As Integer = 0
        Try
            openConnection()
            command = New MySqlCommand(sql, connection)
            counts = Convert.ToInt32(command.ExecuteScalar)


        Catch ex As Exception

            Console.WriteLine("Error counting data " & ex.ToString)
        Finally
            closeConnection()
        End Try
        Return counts
    End Function

End Module
