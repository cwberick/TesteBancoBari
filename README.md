Dependências:
Docker,
.Net Core 3.1+ (SDK ou Runtime)

Abra um prompt de comando em uma máquina com o docker instalado.
Rode o seguinte comando para iniciar o RabbitMQ.
```
 docker run -d --hostname rabbit-host --name rabbitmq -p 15672:15672 -p 5672:5672 rabbitmq:management
```

navegue até a pasta "TesteBancoBari\src\TesteBancoBari.Mensagem.API", abra dois terminais nesta pasta e execute as seguintes linhas de comando em cada um respectivamente:

```
dotnet run --urls=http://localhost:4000/
```

```
dotnet run --urls=http://localhost:4040/
```

Duas instâncias das API's estarão rodando, então abra duas abas do navegador e acesse em cada aba respectivamente:

http://localhost:4000/api/mensagem/start

http://localhost:4040/api/mensagem/start

Após isso volte ao console das API's e veja as mensagens transitando.

Para ver esse processo sem executar esses passos, assista o vídeo StartInstances.mp4 na raíz do repositório.
