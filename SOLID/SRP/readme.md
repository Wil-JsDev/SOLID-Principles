## SRP — Single Responsibility Principle
Este principio establece que una clase debe tener una sola razón para cambiar, es decir, 
debe tener una sola responsabilidad. Si una clase tiene más de una responsabilidad, 
se vuelve más difícil de mantener y entender.

## Ejemplo

- `User.cs`: Esta clase representa el modelo de la entidad de la base de datos.
- `UserRepository.cs`: Esta clase representa la abstracción a la base datos y poder realizar operaciones CRUD, sobre el modelo user. Esto se centra en la persistencia de datos.
- `UserServioce.cs`: Contiene la logica de negocio para gestionar el usuario, como validaciones y posibles transformaciones de datos, para poder enviarlo a la base de datos a traves del repository
- `UserController.cs`: se encarga solamente de manejar las solicitudes HTTP e interactuar con el cliente.