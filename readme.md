This is a simple car license info application to demonstrate/try an gRpc communication using a Blazor Webassembly App as client.

# Setup
```bash
mkdir carLicenseInfo
cd carLicenseInfo

# create a new solution file
dotnet new sln -n CarLicenseInfo

# create the gRPC project
dotnet new grpc -n CarLicenseInfo.Server -o CarLicenseInfo.Server

# add the project to the solution
dotnet sln add CarLicenseInfo.Server
```