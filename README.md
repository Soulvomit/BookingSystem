# BookingSystem

Prereqs:
-Visual Studio 2022
-MSSQL Express with LocalDB

1. Create and seed Database: Run the BookingSystemCreateDatabase project in VS 2022.
2. Migrate Database to version 2: Run command 'update-database' in Package Manager Console.
NOTE: to rollback to first version of database run 'update-database -TargetMigration:InitialCreate' in PM Console.
