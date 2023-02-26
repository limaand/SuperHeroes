# SuperHeroes
API of SuperHeroes .NET


################################################################################################
	Instalação Global EF
################################################################################################


dotnet --version
dotnet tool install --global dotnet-ef
dotnet ef



#################################################################################################
	Criando Migration EF
#################################################################################################
cd .\SuperHeroAPI
dotnet ef migrations add InitialCreate

dotnet ef database update
