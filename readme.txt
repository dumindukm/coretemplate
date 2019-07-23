Enable-Migrations -StartUpProjectName "Pesistence\MySample_DataService"

Enable-Migrations -StartUpProjectName "MySample_API" -verbose

 Add-Migration InitialMigration_SampleDB
Script-Migration