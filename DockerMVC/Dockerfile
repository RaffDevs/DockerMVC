FROM mcr.microsoft.com/dotnet/aspnet:8.0
LABEL version="1.0.2" description="Aplicação Asp.net Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "DockerMVC.dll"]
