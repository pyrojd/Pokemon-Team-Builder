create function UsersLogin
(
@Username VarChar(55),
@UPassword Varchar(55),
@OutRes int
)
returns int
as Begin
set @OutRes = (SELECT count(*) From Users Where Users_Name = '@Username' And Users_Pass = '@UPassword')
return @OutRes
end
