Imports MySql.Data.MySqlClient
Module Module1


    Sub Main()
        Dim adresa As String
        Dim database As String
        Dim passwd As String
        Dim username As String
        ' Dim sql_check As Int16
        Dim sql_veza As New MySqlConnection
        Dim command As New MySqlCommand

        Console.WriteLine("Unesi adresu MySQL servera:")
        adresa = Console.ReadLine()
        Console.WriteLine("Unesi username:")
        username = Console.ReadLine()
        Console.WriteLine("Unesi lozinku:")
        passwd = Console.ReadLine()
        Console.WriteLine("Unesi ime baze podataka:")
        database = Console.ReadLine()

        sql_veza.ConnectionString = String.Format("server={0};user id = {1};password = {2};database = {3};", adresa, username, passwd, database)
        Try
            sql_veza.Open()
            Console.WriteLine("")
            Console.WriteLine("")

            Console.WriteLine("Klikni enter da se obriše tablica podataka za People Counter:")
            Console.ReadLine()

            Try




                Dim query As String = String.Format("USE {0};DROP TABLE brojac_prometa;", database)




                command = New MySqlCommand(query, sql_veza)
                command.ExecuteNonQuery()

                Console.WriteLine("Uspješno obrisano")
            Catch ex As Exception
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine(ex.Message)

            End Try

        Catch ex As Exception
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine(ex.Message)


        End Try

        Console.ReadLine()


    End Sub

End Module
