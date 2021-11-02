using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcWeekFour
{
    enum BookGenre
    {
        SciFi = 1,
        Romance,
        Western,
        PersonalDevelopment,
        NonFiction,
        Mystery
    }

    enum StatusCode
    {
        OK = 200,
        ServerError = 500,
        FileNotFound = 404,
        FileCorrupted,
        FileDeleted
    }

    enum BookStatus
    {
        onShelf,
        CheckedOut,
        Returned
    }
}
