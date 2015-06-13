FROM microsoft/aspnet:1.0.0-beta4

COPY . /app
WORKDIR /app

RUN dnu restore

EXPOSE 5004
ENV DNX_TRACE 1
ENTRYPOINT sleep 10000 | dnx . kestrel
