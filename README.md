# AVL JobFair2019 OData backend

This repository containts the initial OData .NET solution which is neccessary for the AVL JobFair 2019 workshop. 

# Requirements



## Visual Studio 2019 (recommended)
 
 .NET Core 2.2 applications require Visual Studio 2017 version 15.9 or higher. 
 
 - for Windows: https://code.visualstudio.com/docs?dv=win&wt.mc_id=DX_841432&sku=codewin
 - for MacOS: https://code.visualstudio.com/docs?dv=osx&wt.mc_id=DX_841432&sku=codemac
 
## Visual Studio Code

 - for Windows: https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16
 - for MacOS: https://visualstudio.microsoft.com/thank-you-downloading-visual-studio-mac/?sku=communitymac&rel=16
 

## NodeJS

 - for Windows: https://nodejs.org/dist/v10.15.3/node-v10.15.3-x64.msi
 - for MacOS: https://nodejs.org/dist/v10.15.3/node-v10.15.3.pkg
 - for Linux: https://nodejs.org/dist/v10.15.3/node-v10.15.3-linux-x64.tar.xz


## .NET Core

 - for Windows: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer
 - for MacOS: https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer
 - for Linux: https://dotnet.microsoft.com/download/linux-package-manager/rhel/sdk-current

## Good literature

 - https://www.odata.org/documentation/odata-version-2-0/uri-conventions/


# How to run in Visual Studio 2019/2017

 - download repository
 - open .sln file and wait for the files to be loaded properly
 - run IIS Express
 - you will be set to the default Laboratory initialization page
 - test if the measurement data can be loaded via Postman request from the collection
 
# How to run in Visual Studio Code

 - download repository
 - open folder VS2019_version\AVLCarMeasurementDemo\AVLCarMeasurementDemo
 - in terminal type in "dotnet run"
 - you will be redirected to the localhost:5000
 - to initialize Laboratory, go to http://localhost:5000/api/laboratory
 - test if the measurement data can be loaded via Postman request from the collection for VS Code
 
 
# AVL JobFair 2019 Frontend

 - https://github.com/petarili/AVL_JobFair2019_frontend.git
 

