using Percobaan2.Model.Entity;
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using System.Collections.Generic;

namespace Percobaan2.Controller
{
    public class OperatorController
    {
        private OperatorRepository _repository;

        public List<Operator> ReadAll()
        {
            List<Operator> operators = new List<Operator>();

            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                operators = _repository.ReadAll();
            }

            return operators;
        }

        // You can add additional methods for Create, Edit, Delete, etc., as needed.
        // Example:

        public int CreateOperator(Operator operatorObject)
        {
            using (DbContext context = new DbContext())
            {
                _repository = new OperatorRepository(context);
                return _repository.Create(operatorObject);
            }
        }

    }
}
