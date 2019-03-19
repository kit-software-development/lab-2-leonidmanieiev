using System;
using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {
        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>

        private static IClientBuilder clientBuilder;

        public static IClientBuilder ClientBuilder()
        {
            if (clientBuilder == null)
                clientBuilder = new ClientBuilder();

            return clientBuilder;
        }

        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>

        private static IEmployeeBuilder employeeBuilder;

        public static IEmployeeBuilder EmployeeBuilder()
        {
            if (employeeBuilder == null)
                employeeBuilder = new EmployeeBuilder();

            return employeeBuilder;
        }
    }

    internal class ClientBuilder : IClientBuilder
    {
        private IName name;

        private float discount;

        public IClient Build()
        {
            var client = new Client() { Name = name, Discount = discount };
            return client;
        }

        public IClientBuilder Name(IName name)
        {
            this.name = name;
            return this;
        }

        public IClientBuilder Name(string name, string surname, string patronymic)
        {
            return Name(new Name { FirstName = name, Surname = surname, Patronymic = patronymic});
        }

        public IClientBuilder Discount(float discount)
        {
            this.discount = discount;
            return this;
        }
    }

    internal class EmployeeBuilder : IEmployeeBuilder
    {
        private IName name;

        private IDepartment department;

        public IEmployee Build()
        {
            var employee = new Employee() { Name = name, Department = department };
            return employee;
        }

        public IEmployeeBuilder Name(IName name)
        {
            this.name = name;
            return this;
        }

        public IEmployeeBuilder Name(string name, string surname, string patronymic)
        {
            return Name(new Name { FirstName = name, Surname = surname, Patronymic = patronymic });
        }

        public IEmployeeBuilder Department(IDepartment department)
        {
            this.department = department;
            return this;
        }

        public IEmployeeBuilder Department(string department)
        {
            return Department(new Department{ Name = department});
        }
    }
}
