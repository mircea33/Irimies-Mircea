﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Services
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetConnection();
       
    }
}
