namespace FluentValidation.Tests {
	using System;
	using System.Linq;
	using Internal;
	using Results;
	using Xunit;
	using Validators;


	public class StandalonePropertyValidationTester {
		[Fact]
		public void Should_validate_property_value_without_instance() {
			var validator = new NotNullValidator();
			var parentContext = new ValidationContext<string>(null);
			var rule = new PropertyRule(null, x => null, null, null, typeof(string), null) {
				PropertyName = "Surname"
			};
			var result = new ValidationResult();
			var context = new PropertyValidatorContext(parentContext, result, rule, null, null);
			validator.Validate(context);
			result.Errors.Single().ShouldNotBeNull();
		}
	}
}
