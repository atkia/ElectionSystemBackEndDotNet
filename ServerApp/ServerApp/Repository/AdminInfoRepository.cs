using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerApp.Model;

namespace ServerApp.Repository
{
    public class AdminInfoRepository:DatabaseRepository
    {
        public AdminInfo Add(AdminInfo admin) {
            DatabaseContext.Admins.Add(admin);
            DatabaseContext.SaveChanges();
            return admin;
        }

        public AdminInfo getByUsername(String username)
        {
            return DatabaseContext.Admins.SingleOrDefault(Admins => Admins.Username == username);
        }

        public AdminInfo getByPassword(String password)
        {
            return DatabaseContext.Admins.SingleOrDefault(Admins => Admins.password == password);
        }
        public List<AdminInfo> getAll()
        {
            return DatabaseContext.Admins.OrderBy(Admins => Admins.id).ToList();
        }

        public AdminInfo Update(AdminInfo admin)
        {
            DatabaseContext.Admins.Update(admin);
            DatabaseContext.SaveChanges();
            return admin;
        }

        public bool Delete(String username)
        {
            DatabaseContext.Admins.Remove(getByUsername(username));
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
