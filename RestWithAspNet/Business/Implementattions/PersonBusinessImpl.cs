using System.Collections.Generic;
using RestWithAspNet.Data.Converters;
using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;
using RestWithAspNet.Repository.Generic;

namespace RestWithAspNet.Business.Implementattions
{
    public class PersonBusinessImpl : IPersonBusiness
    {

        private IPersonRepository _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IPersonRepository repository)
        {
            _repository = repository;
            _converter = new PersonConverter(); ;
        }

        // Metodo responsável por criar uma nova pessoa
        // nesse momento adicionamos o objeto ao contexto
        // e finalmente salvamos as mudanças no contexto
        // na base de dados
        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Método responsável por retornar uma pessoa
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }


        //Método responsável por retornar todas as pessoas
        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }
        
        public List<PersonVO> FindByName(string firstName, string lastName)
        {
            return _converter.ParseList(_repository.FindByName(firstName, lastName));
        }
        
        // Método responsável por atualizar uma pessoa
        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Método responsável por deletar
        // uma pessoa a partir de um ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

    }
}
