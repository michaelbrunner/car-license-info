
# Demo Application for using gRPC communication in a Blazor WebAssembly Application

The goal of this simple application is to test and learn about gRPC and touching also Blazor WebAssembly.

The user can query german license plates, but only the part of the City or Region.
The data is stored in an SqlLite File DB. The Blazor WebAssembly Frontend communicates with the backend, using gRPC Web.


## Tech Stack

**Client:** 
* Blazor WebAssembly 
* Grpc.Net.Client.Web
* Microsoft .Net Core
  
**Server:**
* Microsoft .Net Core
* Grpc.AspNetCore
* Grpc.AspNetCore.Web

**Grpc:**
* Pure gRPC implementation with PROTO files
  
## Source of data

The car license information is taken from [Wikipedia](https://de.wikipedia.org/wiki/Liste_der_Kfz-Kennzeichen_in_Deutschland)