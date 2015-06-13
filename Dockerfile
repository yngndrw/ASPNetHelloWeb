FROM microsoft/aspnet:1.0.0-beta4

# Cache NuGet packages separately from the code
COPY project.json /app/
WORKDIR /app
RUN dnu restore

COPY . /app

EXPOSE 5004
ENV DNX_TRACE 1
ENTRYPOINT sleep 10000 | dnx . kestrel
