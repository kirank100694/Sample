using System;
using Day40Concepts.ElementOperatorsElementAtVSElementAtORDefault;
using Day40Concepts.ElementOperatorsFirstVsFirstORDefault;
using Day40Concepts.ElementOperatorsLastVsLastORDefault;
using Day40Concepts.ElementOperatorsSingleVsSingleORDefault;
using Day40Concepts.PartitioningOperatorsSkipMethod;
using Day40Concepts.PartitioningOperatorsSkipWhileMethod;
using Day40Concepts.PartitioningOperatorsTakeMethod;
using Day40Concepts.PartitioningOperatorsTakeWhileMethod;
using Day40Concepts.QuantifierOperationAll;
using Day40Concepts.QuantifierOperationAny;
using Day40Concepts.QuantifierOperationContains;
using Day40Concepts.SetOperationsDistinctMethod;
using Day40Concepts.SetOperationsExceptMethod;
using Day40Concepts.SetOperationsIntersectMethod;
using Day40Concepts.SetOperationsUnionMethod;

namespace Day40Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //QuantifierOperations();
            //SetOperations();
            //PartitioningOperators();
            ElementOperations();
        }

        public static void QuantifierOperations()
        {
            AllMethod allMethod = new AllMethod();
            allMethod.AllMethodExample();
            allMethod.AllMethodExample2();
            allMethod.AllmethodComplexExample();

            AnyMethod anyMethod = new AnyMethod();
            anyMethod.AnyMethodExample();
            anyMethod.AnyMethodSimpleExample();
            anyMethod.AnyMethodSimpleExample1();
            anyMethod.AnyMethodComplexExample();

            ContainsMethod containsMethod = new ContainsMethod();
            containsMethod.ContainsMethodExample();
            containsMethod.ContainsMethodExample2();
            containsMethod.ContainsMethodComplexExample();
        }

        public static void SetOperations()
        {
            DistinctMethod distinctMethod = new DistinctMethod();
            distinctMethod.DistinctMethodExample();
            distinctMethod.DistinctMethodComplexExample();

            ExceptMethod exceptMethod = new ExceptMethod();
            exceptMethod.ExceptMethodExample();
            exceptMethod.ExceptMethodSimpleExample();
            exceptMethod.ExceptMethodComplexExample();

            IntersectMethod intersectMethod = new IntersectMethod();    
            intersectMethod.IntersectMethodExample();
            intersectMethod.IntersectMethodSimpleExample();
            intersectMethod.IntersectMethodComplexExample();

            UnionMethod unionMethod = new UnionMethod();
            unionMethod.UnionMethodExample();
            unionMethod.UnionMethodSimpleExample();
            unionMethod.UnionMethodComplexExample();
        }

        public static void PartitioningOperators()
        {
            TakeMethod takeMethod = new TakeMethod();
            takeMethod.TakeMethodExample();
            takeMethod.TakeMethodComplexExample();

            TakeWhileMethod takeWhileMethod = new TakeWhileMethod();
            takeWhileMethod.TakeWhileMethodExample();
            takeWhileMethod.TakeWhileMethodSimpleExample();

            SkipMethod skipMethod = new SkipMethod();
            skipMethod.SkipMethodExample();
            skipMethod.SkipMethodSimpleExample();

            SkipWhileMethod skipWhileMethod = new SkipWhileMethod();
            skipWhileMethod.SkipWhileMethodExample();
            skipWhileMethod.SkipWhileMethodSimpleExample();
        }

        public static void ElementOperations()
        {
            FirstVSFirstOrDefaultMethod firstMethod = new FirstVSFirstOrDefaultMethod();
            firstMethod.FirstVSFirstOrDefaultMethodExample();
            firstMethod.FirstVSFirstOrDefaultMethodComplexExample();

            LastVSLastOrDefaultMethod lastMethod = new LastVSLastOrDefaultMethod();
            lastMethod.LastVSLastOrDefaultMethodExample();
            lastMethod.LastVSLastOrDefaultMethodSimpleExample();

            SingleVSSingleOrDefaultMethod singleMethod = new SingleVSSingleOrDefaultMethod();
            singleMethod.SingleVSSingleOrDefaultMethodExample();
            singleMethod.SingleVSSingleOrDefaultMethodSimpleExample();

            ElementAtVSElementAtORDefaultMethod elementMethod = new ElementAtVSElementAtORDefaultMethod();
            elementMethod.ElementAtVSElementAtORDefaultExample();
            elementMethod.ElementAtVSElementAtORDefaultSimpleExample();
        }
    }
}
