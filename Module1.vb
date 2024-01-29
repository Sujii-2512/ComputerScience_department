Imports MySql.Data.MySqlClient
Module Module1
    Public con As ADODB.Connection
    Public rs As ADODB.Recordset
    Public Function con_open()
        con = New ADODB.Connection
        con.Open("Dsn=NAAC Report;port=3306;username=root;password=root")
        MsgBox("Connection Success")
        Exit Function
        MsgBox("Connection failed")
    End Function
    Public Function rec_open(sql)
        rs = New ADODB.Recordset
        rs.Open(sql, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Return rs
    End Function
End Module
