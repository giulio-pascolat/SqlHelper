﻿using SqlClient;

const string connectionString = "Server=COMPUTER\\SQLEXPRESS;Database=ToDoList;TrustServerCertificate=True;Trusted_Connection=True;";

using var database = new Database(connectionString);
using var unitOfWork = new UnitOfWork(database);

unitOfWork.Work();