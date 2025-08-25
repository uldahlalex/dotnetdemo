Valgfrit: Lav ny mappe som hedder projektets navn fx "mydempapp": mkdir mydemoapp && cd mydemoapp

mkdir client
cd client
npm create vite
cd ..
mkdir server
cd server
dotnet new gitignore
dotnet new sln 
mkdir dataaccess
mkdir service
cd dataaccess
dotnet new classlib
cd ..
cd service
dotnet new console
cd ..
dotnet sln add (peg på begge .csproj filer i hver mappe)

Dernæst åbn .sln filen med jeres IDE

(fra rod-mappen): git init + gh repo create 

