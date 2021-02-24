Abra um prompt de comando em uma máquina com o docker instalado.
Rode o seguinte comando
```
 docker run -d --hostname rabbit-host --name rabbitmq -p 15672:15672 -p 5672:5672 rabbitmq:management
```

Depois abra o arquivo TesteBancoBari.sln no Visual Studio.

Assista o vídeo StartIntances.mp4 para ver como criar as instâncias do microserviço e ver as mensangens transitando.