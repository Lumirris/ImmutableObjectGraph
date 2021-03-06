﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ImmutableTree Version: 0.0.0.1
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Demo {
	using System.Diagnostics;
	using System.Linq;
	using ImmutableObjectGraph;
	
	public partial class Message {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Message DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Contact author;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> to;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> cc;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.Collections.Immutable.ImmutableList<Contact> bcc;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String subject;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String body;
	
		private readonly System.UInt32 identity;
	
		/// <summary>Initializes a new instance of the Message class.</summary>
		protected Message(
			System.UInt32 identity,
			Contact author,
			System.Collections.Immutable.ImmutableList<Contact> to,
			System.Collections.Immutable.ImmutableList<Contact> cc,
			System.Collections.Immutable.ImmutableList<Contact> bcc,
			System.String subject,
			System.String body,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
		{
			this.identity = identity;
			this.author = author;
			this.to = to;
			this.cc = cc;
			this.bcc = bcc;
			this.subject = subject;
			this.body = body;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static Message Create(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				author: Optional.For(author.GetValueOrDefault(DefaultInstance.Author)),
				to: Optional.For(to.GetValueOrDefault(DefaultInstance.To)),
				cc: Optional.For(cc.GetValueOrDefault(DefaultInstance.Cc)),
				bcc: Optional.For(bcc.GetValueOrDefault(DefaultInstance.Bcc)),
				subject: Optional.For(subject.GetValueOrDefault(DefaultInstance.Subject)),
				body: Optional.For(body.GetValueOrDefault(DefaultInstance.Body)),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public Contact Author {
			get { return this.author; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> To {
			get { return this.to; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> Cc {
			get { return this.cc; }
		}
	
		public System.Collections.Immutable.ImmutableList<Contact> Bcc {
			get { return this.bcc; }
		}
	
		public System.String Subject {
			get { return this.subject; }
		}
	
		public System.String Body {
			get { return this.body; }
		}
		
		/// <summary>Returns a new instance with the Author property set to the specified value.</summary>
		public Message WithAuthor(Contact value) {
			if (value == this.Author) {
				return this;
			}
		
			return this.With(author: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the To property set to the specified value.</summary>
		public Message WithTo(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.To) {
				return this;
			}
		
			return this.With(to: Optional.For(value));
		}
		
		/// <summary>Replaces the elements of the To collection with the specified collection.</summary>
		public Message WithTo(params Contact[] values) {
			return this.With(to: this.To.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the To collection with the specified collection.</summary>
		public Message WithTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the To collection.</summary>
		public Message AddTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the To collection.</summary>
		public Message AddTo(params Contact[] values) {
			return this.With(to: this.To.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the To collection.</summary>
		public Message AddTo(Contact value) {
			return this.With(to: this.To.Add(value));
		}
		
		/// <summary>Removes the specified elements from the To collection.</summary>
		public Message RemoveTo(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(to: this.To.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the To collection.</summary>
		public Message RemoveTo(params Contact[] values) {
			return this.With(to: this.To.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the To collection.</summary>
		public Message RemoveTo(Contact value) {
			return this.With(to: this.To.Remove(value));
		}
		
		/// <summary>Clears all elements from the To collection.</summary>
		public Message RemoveTo() {
			return this.With(to: this.To.Clear());
		}
		
		
		/// <summary>Returns a new instance with the Cc property set to the specified value.</summary>
		public Message WithCc(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.Cc) {
				return this;
			}
		
			return this.With(cc: Optional.For(value));
		}
		
		/// <summary>Replaces the elements of the Cc collection with the specified collection.</summary>
		public Message WithCc(params Contact[] values) {
			return this.With(cc: this.Cc.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Cc collection with the specified collection.</summary>
		public Message WithCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Cc collection.</summary>
		public Message AddCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Cc collection.</summary>
		public Message AddCc(params Contact[] values) {
			return this.With(cc: this.Cc.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Cc collection.</summary>
		public Message AddCc(Contact value) {
			return this.With(cc: this.Cc.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Cc collection.</summary>
		public Message RemoveCc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(cc: this.Cc.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Cc collection.</summary>
		public Message RemoveCc(params Contact[] values) {
			return this.With(cc: this.Cc.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Cc collection.</summary>
		public Message RemoveCc(Contact value) {
			return this.With(cc: this.Cc.Remove(value));
		}
		
		/// <summary>Clears all elements from the Cc collection.</summary>
		public Message RemoveCc() {
			return this.With(cc: this.Cc.Clear());
		}
		
		
		/// <summary>Returns a new instance with the Bcc property set to the specified value.</summary>
		public Message WithBcc(System.Collections.Immutable.ImmutableList<Contact> value) {
			if (value == this.Bcc) {
				return this;
			}
		
			return this.With(bcc: Optional.For(value));
		}
		
		/// <summary>Replaces the elements of the Bcc collection with the specified collection.</summary>
		public Message WithBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.ResetContents(values));
		}
		
		/// <summary>Replaces the elements of the Bcc collection with the specified collection.</summary>
		public Message WithBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.ResetContents(values));
		}
		
		/// <summary>Adds the specified elements from the Bcc collection.</summary>
		public Message AddBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.AddRange(values));
		}
		
		/// <summary>Adds the specified elements from the Bcc collection.</summary>
		public Message AddBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.AddRange(values));
		}
		
		/// <summary>Adds the specified element from the Bcc collection.</summary>
		public Message AddBcc(Contact value) {
			return this.With(bcc: this.Bcc.Add(value));
		}
		
		/// <summary>Removes the specified elements from the Bcc collection.</summary>
		public Message RemoveBcc(System.Collections.Generic.IEnumerable<Contact> values) {
			return this.With(bcc: this.Bcc.RemoveRange(values));
		}
		
		/// <summary>Removes the specified elements from the Bcc collection.</summary>
		public Message RemoveBcc(params Contact[] values) {
			return this.With(bcc: this.Bcc.RemoveRange(values));
		}
		
		/// <summary>Removes the specified element from the Bcc collection.</summary>
		public Message RemoveBcc(Contact value) {
			return this.With(bcc: this.Bcc.Remove(value));
		}
		
		/// <summary>Clears all elements from the Bcc collection.</summary>
		public Message RemoveBcc() {
			return this.With(bcc: this.Bcc.Clear());
		}
		
		
		/// <summary>Returns a new instance with the Subject property set to the specified value.</summary>
		public Message WithSubject(System.String value) {
			if (value == this.Subject) {
				return this;
			}
		
			return this.With(subject: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the Body property set to the specified value.</summary>
		public Message WithBody(System.String value) {
			if (value == this.Body) {
				return this;
			}
		
			return this.With(body: Optional.For(value));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Message With(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>)) {
			return (Message)this.WithCore(
				author: author,
				to: to,
				cc: cc,
				bcc: bcc,
				subject: subject,
				body: body);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual Message WithCore(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.UInt32>);
			return this.WithFactory(
				author: Optional.For(author.GetValueOrDefault(this.Author)),
				to: Optional.For(to.GetValueOrDefault(this.To)),
				cc: Optional.For(cc.GetValueOrDefault(this.Cc)),
				bcc: Optional.For(bcc.GetValueOrDefault(this.Bcc)),
				subject: Optional.For(subject.GetValueOrDefault(this.Subject)),
				body: Optional.For(body.GetValueOrDefault(this.Body)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private Message WithFactory(
			ImmutableObjectGraph.Optional<Contact> author = default(ImmutableObjectGraph.Optional<Contact>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> to = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> cc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>> bcc = default(ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>>),
			ImmutableObjectGraph.Optional<System.String> subject = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> body = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(author.IsDefined && author.Value != this.Author) || 
				(to.IsDefined && to.Value != this.To) || 
				(cc.IsDefined && cc.Value != this.Cc) || 
				(bcc.IsDefined && bcc.Value != this.Bcc) || 
				(subject.IsDefined && subject.Value != this.Subject) || 
				(body.IsDefined && body.Value != this.Body)) {
				return new Message(
					identity: identity.GetValueOrDefault(this.Identity),
					author: author.GetValueOrDefault(this.Author),
					to: to.GetValueOrDefault(this.To),
					cc: cc.GetValueOrDefault(this.Cc),
					bcc: bcc.GetValueOrDefault(this.Bcc),
					subject: subject.GetValueOrDefault(this.Subject),
					body: body.GetValueOrDefault(this.Body));
			} else {
				return this;
			}
		}
	
		protected internal uint Identity {
			get { return (uint)this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.UInt32 NewIdentity() {
			return (System.UInt32)System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Message whose fields are initialized with default values.</summary>
		private static Message GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Message(
				default(System.UInt32),
				template.Author,
				template.To,
				template.Cc,
				template.Bcc,
				template.Subject,
				template.Body,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal Contact Author { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> To { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> Cc { get; set; }
	
			internal System.Collections.Immutable.ImmutableList<Contact> Bcc { get; set; }
	
			internal System.String Subject { get; set; }
	
			internal System.String Body { get; set; }
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public static Builder CreateBuilder() {
			return new Builder(DefaultInstance);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Message immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<Contact.Builder> author;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> to;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> cc;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected ImmutableObjectGraph.Optional<System.Collections.Immutable.ImmutableList<Contact>.Builder> bcc;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String subject;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String body;
		
			internal Builder(Message immutable) {
				this.immutable = immutable;
		
				this.subject = immutable.Subject;
				this.body = immutable.Body;
			}
		
			public Contact.Builder Author {
				get {
					if (!this.author.IsDefined) {
						this.author = this.immutable.author != null ? this.immutable.author.ToBuilder() : null;
					}
		
					return this.author.Value;
				}
		
				set {
					this.author = value;
				}
			}
		
			public System.Collections.Immutable.ImmutableList<Contact>.Builder To {
				get {
					if (!this.to.IsDefined) {
						this.to = this.immutable.to != null ? this.immutable.to.ToBuilder() : null;
					}
		
					return this.to.Value;
				}
		
				set {
					this.to = value;
				}
			}
		
			public System.Collections.Immutable.ImmutableList<Contact>.Builder Cc {
				get {
					if (!this.cc.IsDefined) {
						this.cc = this.immutable.cc != null ? this.immutable.cc.ToBuilder() : null;
					}
		
					return this.cc.Value;
				}
		
				set {
					this.cc = value;
				}
			}
		
			public System.Collections.Immutable.ImmutableList<Contact>.Builder Bcc {
				get {
					if (!this.bcc.IsDefined) {
						this.bcc = this.immutable.bcc != null ? this.immutable.bcc.ToBuilder() : null;
					}
		
					return this.bcc.Value;
				}
		
				set {
					this.bcc = value;
				}
			}
		
			public System.String Subject {
				get {
					return this.subject;
				}
		
				set {
					this.subject = value;
				}
			}
		
			public System.String Body {
				get {
					return this.body;
				}
		
				set {
					this.body = value;
				}
			}
		
			public Message ToImmutable() {
				var author = this.author.IsDefined ? (this.author.Value != null ? this.author.Value.ToImmutable() : null) : this.immutable.Author;
				var to = this.to.IsDefined ? (this.to.Value != null ? this.to.Value.ToImmutable() : null) : this.immutable.To;
				var cc = this.cc.IsDefined ? (this.cc.Value != null ? this.cc.Value.ToImmutable() : null) : this.immutable.Cc;
				var bcc = this.bcc.IsDefined ? (this.bcc.Value != null ? this.bcc.Value.ToImmutable() : null) : this.immutable.Bcc;
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(author),
					ImmutableObjectGraph.Optional.For(to),
					ImmutableObjectGraph.Optional.For(cc),
					ImmutableObjectGraph.Optional.For(bcc),
					ImmutableObjectGraph.Optional.For(this.Subject),
					ImmutableObjectGraph.Optional.For(this.Body));
			}
		}
	}
	
	public partial class Contact {
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Contact DefaultInstance = GetDefaultTemplate();
		
		/// <summary>The last identity assigned to a created instance.</summary>
		private static int lastIdentityProduced;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String name;
	
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly System.String email;
	
		private readonly System.UInt32 identity;
	
		/// <summary>Initializes a new instance of the Contact class.</summary>
		protected Contact(
			System.UInt32 identity,
			System.String name,
			System.String email,
			ImmutableObjectGraph.Optional<bool> skipValidation = default(ImmutableObjectGraph.Optional<bool>))
		{
			this.identity = identity;
			this.name = name;
			this.email = email;
			if (!skipValidation.Value) {
				this.Validate();
			}
		}
	
		public static Contact Create(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = Optional.For(NewIdentity());
			return DefaultInstance.WithFactory(
				name: Optional.For(name.GetValueOrDefault(DefaultInstance.Name)),
				email: Optional.For(email.GetValueOrDefault(DefaultInstance.Email)),
				identity: Optional.For(identity.GetValueOrDefault(DefaultInstance.Identity)));
		}
	
		public System.String Name {
			get { return this.name; }
		}
	
		public System.String Email {
			get { return this.email; }
		}
		
		/// <summary>Returns a new instance with the Name property set to the specified value.</summary>
		public Contact WithName(System.String value) {
			if (value == this.Name) {
				return this;
			}
		
			return this.With(name: Optional.For(value));
		}
		
		/// <summary>Returns a new instance with the Email property set to the specified value.</summary>
		public Contact WithEmail(System.String value) {
			if (value == this.Email) {
				return this;
			}
		
			return this.With(email: Optional.For(value));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		public Contact With(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>)) {
			return (Contact)this.WithCore(
				name: name,
				email: email);
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		protected virtual Contact WithCore(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>)) {
			var identity = default(ImmutableObjectGraph.Optional<System.UInt32>);
			return this.WithFactory(
				name: Optional.For(name.GetValueOrDefault(this.Name)),
				email: Optional.For(email.GetValueOrDefault(this.Email)),
				identity: Optional.For(identity.GetValueOrDefault(this.Identity)));
		}
	
		/// <summary>Returns a new instance of this object with any number of properties changed.</summary>
		private Contact WithFactory(
			ImmutableObjectGraph.Optional<System.String> name = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.String> email = default(ImmutableObjectGraph.Optional<System.String>),
			ImmutableObjectGraph.Optional<System.UInt32> identity = default(ImmutableObjectGraph.Optional<System.UInt32>)) {
			if (
				(identity.IsDefined && identity.Value != this.Identity) || 
				(name.IsDefined && name.Value != this.Name) || 
				(email.IsDefined && email.Value != this.Email)) {
				return new Contact(
					identity: identity.GetValueOrDefault(this.Identity),
					name: name.GetValueOrDefault(this.Name),
					email: email.GetValueOrDefault(this.Email));
			} else {
				return this;
			}
		}
	
		protected internal uint Identity {
			get { return (uint)this.identity; }
		}
	
		/// <summary>Returns a unique identity that may be assigned to a newly created instance.</summary>
		protected static System.UInt32 NewIdentity() {
			return (System.UInt32)System.Threading.Interlocked.Increment(ref lastIdentityProduced);
		}
	
		/// <summary>Normalizes and/or validates all properties on this object.</summary>
		/// <exception type="ArgumentException">Thrown if any properties have disallowed values.</exception>
		partial void Validate();
	
		/// <summary>Provides defaults for fields.</summary>
		/// <param name="template">The struct to set default values on.</param>
		static partial void CreateDefaultTemplate(ref Template template);
	
		/// <summary>Returns a newly instantiated Contact whose fields are initialized with default values.</summary>
		private static Contact GetDefaultTemplate() {
			var template = new Template();
			CreateDefaultTemplate(ref template);
			return new Contact(
				default(System.UInt32),
				template.Name,
				template.Email,
				skipValidation: true);
		}
	
		/// <summary>A struct with all the same fields as the containing type for use in describing default values for new instances of the class.</summary>
		private struct Template {
			internal System.String Name { get; set; }
	
			internal System.String Email { get; set; }
		}
		
		public Builder ToBuilder() {
			return new Builder(this);
		}
		
		public static Builder CreateBuilder() {
			return new Builder(DefaultInstance);
		}
		
		public partial class Builder {
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Contact immutable;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String name;
		
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			protected System.String email;
		
			internal Builder(Contact immutable) {
				this.immutable = immutable;
		
				this.name = immutable.Name;
				this.email = immutable.Email;
			}
		
			public System.String Name {
				get {
					return this.name;
				}
		
				set {
					this.name = value;
				}
			}
		
			public System.String Email {
				get {
					return this.email;
				}
		
				set {
					this.email = value;
				}
			}
		
			public Contact ToImmutable() {
				return this.immutable = this.immutable.With(
					ImmutableObjectGraph.Optional.For(this.Name),
					ImmutableObjectGraph.Optional.For(this.Email));
			}
		}
	}
}


