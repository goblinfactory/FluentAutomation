﻿using FluentAutomation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace FluentAutomation.Tests.Actions
{
    public class FindTests : BaseTest
    {
        public FindTests()
            : base()
        {
            InputsPage.Go();
        }

        [Fact]
        public void FindElement()
        {
            var element = I.Find(InputsPage.TextControlSelector).Element;

            // simple assert on element to ensure it was properly loaded
            Assert.True(element.IsText);
            Assert.Throws<FluentElementNotFoundException>(() => I.Find("doesntexist").Element);
        }

        [Fact]
        public void FindSpecificElementTest()
        {
            Assert.True(I.Find(InputsPage.ButtonControlSelector).Element.Text == "Button");
        }


        [Fact]
        public void FindMultipleElements()
        {
            var proxy = I.FindMultiple("div");

            Assert.True(proxy.Elements.Count > 1);
            Assert.False(proxy.Element.IsText);
            Assert.True(proxy.Element.Text == proxy.Element.Value);
        }

        [Fact]
        public void AttemptToFindFakeElement()
        {
            var exception = Assert.Throws<FluentElementNotFoundException>(() => I.Find("#fake-control").Element.ToString()); // accessing Element executes the Find
            Assert.True(exception.Message.Contains("Unable to find"));
            Assert.Throws<FluentElementNotFoundException>(() => I.FindMultiple("doesntexist").Element);
        }
    }
}
