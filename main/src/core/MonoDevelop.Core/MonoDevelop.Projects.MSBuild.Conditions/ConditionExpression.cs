//
// ConditionExpression.cs
//
// Author:
//   Marek Sieradzki (marek.sieradzki@gmail.com)
// 
// (C) 2006 Marek Sieradzki
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Xml;

namespace MonoDevelop.Projects.MSBuild.Conditions {
	internal abstract class ConditionExpression {

		public abstract bool BoolEvaluate (IExpressionContext context);
		public abstract float NumberEvaluate (IExpressionContext context);
		public abstract string StringEvaluate (IExpressionContext context);
		public virtual Version VersionEvaluate (IExpressionContext context) => throw new NotSupportedException();
		
		public abstract bool CanEvaluateToBool (IExpressionContext context);
		public abstract bool CanEvaluateToNumber (IExpressionContext context);
		public abstract bool CanEvaluateToString (IExpressionContext context);
		public virtual bool CanEvaluateToVersion (IExpressionContext context) => false;

		public virtual void CollectConditionProperties (ConditionedPropertyCollection properties)
		{
		}
	}
}
