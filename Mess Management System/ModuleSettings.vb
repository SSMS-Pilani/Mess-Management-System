Module ModuleSettings

    Public by_scanner_only As Boolean = False

    Public Photos_Location As String = "D:\Photos\"

    Public Cash_On As Boolean = True

    Public Max_Limit_SET As String = "GRANT ALL ON mess.* TO 'root'@'localhost' WITH MAX_QUERIES_PER_HOUR 200000000000 MAX_UPDATES_PER_HOUR 200000000000 MAX_CONNECTIONS_PER_HOUR 1000000 MAX_USER_CONNECTIONS 100;"

    Public Max_Days_Delete_Entries As Integer = 3

    Public Rebate_Min_days As Integer = 3



End Module
