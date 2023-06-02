using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class EmployeeServices
	{
		private EmployeeRepositoy _repo;

		public EmployeeServices()
		{
			_repo = new EmployeeRepositoy();
		}
		public EmployeeServices(EmployeeRepositoy repo)
		{
			_repo = repo;
		}

		public EmployeeDto Get(string account)
		{
			return _repo.Get(account);
		}

		public int Update(EmployeeDto dto)
		{
			return _repo.Update(dto);
		}

		public List<EmployeeDto> GetAll()
		{
			return _repo.GetAll();
		}

		public int Create(EmployeeDto dto)
		{
			return (_repo.Create(dto));
		}

		public int Delete(string account)
		{
			return (int)_repo.Delete(account);
		}
	}
}
