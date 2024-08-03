using System;
using Day39Concepts.WaysToWriteALINQuery;
using Day39Concepts.ExtensionMethodsExamples;
using Day39Concepts.SelectMethodProjectionOperator;
using Day39Concepts.SelectManyInProjectionOperations;
using Day39Concepts.FilteringOperatorsTypes;
using Day39Concepts.SortingOperatorsTypes;

namespace Day39Concepts
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteALINQuery writeALINQuery = new WriteALINQuery();
            writeALINQuery.QuerySyntax();
            writeALINQuery.MethodSyntax();
            writeALINQuery.MixedSyntax();

            ExtensionMethods extensionMethods = new ExtensionMethods();
            extensionMethods.DisplayExtensionMethod();
            extensionMethods.DisplayEnumerable();

            SelectInMethod selectMethod = new SelectInMethod();
            selectMethod.DisplayBasicQueryInSelectMethod();
            selectMethod.DisplaySelectInQueryMethod();
            selectMethod.DisplaySelectInOperator();
            selectMethod.GetCompanyEmployees();

            SelectManyInMethod selectManyInMethod = new SelectManyInMethod();
            selectManyInMethod.DisplaySelectManyProjectionOperations();
            selectManyInMethod.DisplaySelectManyDataSource();
            selectManyInMethod.DisplaySelectManyInExample();

            FilteringOperators filteringOperators = new FilteringOperators();
            filteringOperators.WhereMethod();
            filteringOperators.WhereMethodExample();
            filteringOperators.WhereMethodSimpleExample();
            filteringOperators.WhereMethodComplexExample();
            filteringOperators.OfTypeMethod();
            filteringOperators.OfTypeMethodExample();

            SortingOperators sortingOperators = new SortingOperators();
            sortingOperators.OrderByMethod();
            sortingOperators.OrderByMethodExample();
            sortingOperators.OrderByMethodComplexExample();
            sortingOperators.OrderByDescendingMethod();
            sortingOperators.OrderByDescendingMethodExample();
            sortingOperators.OrderByDecendingMethodComplexExample();
            sortingOperators.ReverseMethod();
            sortingOperators.ReverseMethodExample();


        }
    }
}
