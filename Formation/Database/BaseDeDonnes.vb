Imports MySql.Data.MySqlClient

Module BaseDeDonnes

    Private ReadOnly Property HostName As String
        Get
            Return My.Settings.db_serveur
        End Get
    End Property

    Private ReadOnly Property DatabaseName As String
        Get
            Return My.Settings.db_nom
        End Get
    End Property

    Private Property UserId As String = My.Settings.db_user
    Private Property Password As String = My.Settings.db_pass

    ''' <summary>
    ''' Permet de creer la connexion
    ''' </summary>
    ''' <returns></returns>
    Public Function GetConnection() As MySqlConnection

        Dim chaineConnection As String = String.Format("Datasource={0};Database={1};User id={2};password={3}", HostName, DatabaseName, UserId, Password)
        Dim cnx As MySqlConnection = New MySqlConnection(chaineConnection)
        If cnx.State <> ConnectionState.Open Then
            cnx.Open()
        End If
        Return cnx
    End Function

    ''' <summary>
    ''' Permet d'initialiser une commande
    ''' </summary>
    ''' <param name="sql">La requete sql a executer</param>
    ''' <returns></returns>
    Public Function GetCommand(sql As String) As MySqlCommand
        Dim cmd As MySqlCommand = GetConnection().CreateCommand
        cmd.CommandText = sql
        Return cmd
    End Function

End Module
