

Cohesión
Se aplicó el principio de alta cohesión porque cada clase se centra únicamente en su responsabilidad. Ej: La clase Pedido solo contiene los datos del pedido mientras que el PedidoRepositoryTxt se ocupa de guardar y leer en el archivo, y a su vez PedidoServive se encarga de las modificaciones. Y pues así, cada uno de estos componentes tiene un rol especifico y claro, lo que reduce la complejidad, también facilita y hace que el sistema sea un poco más ordenado y, por ende, más entendible. 
 
 Acoplamiento
También aplicamos el principio de bajo acoplamiento, para que si en el futuro se quisiera cambiar el mecanismo de almacenamiento (por ejemplo, de un archivo TXT a una base de datos o a un archivo JSON), no tendría que modificar la lógica del servicio, sino solo crear una nueva implementación del repositorio.
Entonces de esta forma, el sistema queda un poco más flexible, y menos dependiente, por lo tanto, queda preparado para cambios futuros sin afectar las demás capas.
