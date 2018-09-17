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


            Try
                Dim query As String = String.Format("USE {0};CREATE TABLE brojac_prometa (Datum DATE,Posjeta MEDIUMINT,Primary Key(Datum))", database)





                Console.WriteLine("Klikni enter da se izvrši postavljanje tablice za People Counter:")
                Console.ReadLine()

                command = New MySqlCommand(query, sql_veza)
                Command.ExecuteNonQuery()

                Console.WriteLine("Tablica dodana")
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
