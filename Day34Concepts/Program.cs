using System;
using Day34Concepts.WhyEnumsConcept;
using Day34Concepts.EmumarablesExample;
using Age = Day34Concepts.ExceptionHandlingInCSharp;
using Day34Concepts.ExceptionType;
using Day34Concepts.AsynchronousProgrammingInCSharp;
using Day34Concepts.DebugVsReleaseConcepts;
using Day34Concepts.ArraysConcept;
using Day34Concepts.ComparingTwoArraysConcept;
using Day34Concepts.EnumsConcepts;

namespace Day34Concepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WhyEnums whyEnums = new WhyEnums();
            whyEnums.WhyEnumsExample();

            EnumsExample enumsExample = new EnumsExample();
            enumsExample.EnumsExamples();

            EnumConcepts enumsConcept = new EnumConcepts();
            enumsConcept.EnumsConceptExample();

            Age.ExceptionHandling exceptionHandling = new Age.ExceptionHandling();
            exceptionHandling.ExceptionHandlingExample();
            exceptionHandling.ExceptionHandlingExample1();

            ExceptionTypes.DisplayExceptionType();
            ExceptionTypes.ExceptionTypeExample();
            AsynchronousProgramming.DisplayAsychronous();
            DebugVsRelease.DisplayDebugVsRelease();
            Arrays.ArraysExample();
            ComparingTwoArrays.ComparingArraysExample();
            ComparingTwoArrays.ComparingArraysExample1();
        }
    }
}

