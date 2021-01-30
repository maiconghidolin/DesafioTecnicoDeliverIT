using System;
using System.Collections.Generic;

namespace ProjetoBase.Domain.Extensions
{
    public static class ListExtension
    {

		public static bool IsNullOrEmpty<T>(this List<T> lista)
		{
			return (lista == null || lista.Count == 0);
		}

		public static bool IsNotNullOrEmpty<T>(this List<T> lista)
		{
			return (lista != null && lista.Count > 0);
		}

		public static string Join<T>(this List<T> lista, string separador = ", ")
		{
            try
            {
				return string.Join(separador, lista);
			}
            catch (Exception)
            {
				return "";
            }
		}

	}
}
