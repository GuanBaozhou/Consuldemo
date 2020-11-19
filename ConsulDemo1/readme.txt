dotnet ConsulDemo1.dll --urls="http://*:5726" --ip="192.168.20.244" --port=5726 --weight=1

ip要使用IP， 不能使用127.0.0.1

 docker run -d -p 8500:8500 -v /data/consul:/consul/data -e CONSUL_BIND_INTERFACE='eth0' --name=consul_server_1 consul agent -server -bootstrap -ui -node=1 -client='0.0.0.0'

 docker exec consul_server_1 consul members

 docker run -d -e CONSUL_BIND_INTERFACE='eth0' --name=consul_server_3 consul agent -server -node=3 -join='172.17.0.2'