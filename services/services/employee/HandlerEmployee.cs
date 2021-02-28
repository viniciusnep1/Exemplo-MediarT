using core.config;
using entities.entities;
using MediatR;
using services.services.employee.commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace services.services.employee
{
    public class HandlerEmployee : IRequestHandler<ReadEmployeeCommand, Response>
    {
        public HandlerEmployee()
        {

        }


        public async Task<Response> Handle(ReadEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Name = "José Maria",
                Description = "Analista de sistemas"
            };

            return await Task.FromResult(new Response(employee));
        }
    }
}
