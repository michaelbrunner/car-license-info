This is a simple car license info application to demonstrate/try an gRpc communication using a Blazor Webassembly App as client.

# Setup
```bash
mkdir carLicenseInfo
cd carLicenseInfo

# create a new solution file
dotnet new sln -n CarLicenseInfo

## Create Server
# create the gRPC project
dotnet new grpc -n CarLicenseInfo.Server -o CarLicenseInfo.Server

# add the project to the solution
dotnet sln add CarLicenseInfo.Server
```

## Create Blazor WebAssembly Client
dotnet new blazorwasm -o CarLicenseInfo.Client              

# add the project to the solution
dotnet sln add CarLicenseInfo.Client

# Implementation
## Configure gRPC-Web
- Add nuget package Grpc.AspNetCore.Web to the server project
- Configure to use gRPC Web and enable gRTPC Web on the endpoints
- Configure CORS for gRPC