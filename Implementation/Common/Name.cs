namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; set; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; set; }

        public string FullName => FirstName + ' ' + Patronymic + ' ' + Surname;

        public string ShortName => Surname + ' ' + FirstName[0] + ". " + Patronymic[0] + '.';
    }
}
