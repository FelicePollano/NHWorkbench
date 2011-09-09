// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HqlIntellisense.ConfigurationAbstraction;
using NUnit.Framework;
using HqlIntellisense;
using NHibernate.Cfg;
using System.Reflection;

namespace TestHqlIntellisense
{
    [TestFixture]
    public class Tests:IHQLCompletionRequestor
    {
        List<HQLCompletionProposal> proposals = new List<HQLCompletionProposal>();
        [Test]
        public void TestBeginToWriteHQL()
        {
            HQLCodeAssist assist = new HQLCodeAssist(null);
            assist.CodeComplete("", 0, this);
        }

        [SetUp]
        public void SetUp()
        {
            proposals.Clear();
        }

        [Test]
        public void TestCompleteWhere()
        {
            HQLCodeAssist assist = new HQLCodeAssist(null);
            assist.CodeComplete("from xxxxxx e where ", 20, this);
            Assert.That(proposals.Any(q=>q.SimpleName=="e"));
        }

        [Test]
        public void TestCompleteIn()
        {
            HQLCodeAssist assist = new HQLCodeAssist(null);
            assist.CodeComplete("from xxxxxx e where e.id in ( select id from other x where  )", 59, this);
            Assert.That(proposals.Any(q => q.SimpleName == "x"));
        }
        [Test]
        public void TestCompleteShouldEmitNothing()
        {
            HQLCodeAssist assist = new HQLCodeAssist(null);
            assist.CodeComplete("from xxxxxx e where e.", 22, this);
            Assert.That(proposals.Count == 0);
        }

        [Test]
        public void TestSelectPropertyCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
            assist.CodeComplete("select x. from MyEntity x", 9, this);
            Assert.That(proposals.Count == 5);
        }
        [Test]
        public void TestSelectManyToOneCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
            assist.CodeComplete("select x.Referenced. from MyEntity x", 20, this);
            Assert.That(proposals.Count == 3);
        }

        [Test]
        public void TestWherePropertyCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
            assist.CodeComplete("from MyEntity x where x.", 24, this);
            Assert.That(proposals.Count == 5);
        }
        [Test]
        public void TestWhereOnManyToOnePropertyCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
            assist.CodeComplete("from MyEntity x where x.Referenced.", 35, this);
            Assert.That(proposals.Count == 3);
        }
        [Test]
        public void TestEntitiesCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
            assist.CodeComplete("from ", 5, this);
            Assert.That(proposals.Count == 4);
        }
        [Test]
        public void TestNestedPropertyCompletion()
        {
            Configuration cfg = CreateCfg();
            HQLCodeAssist assist = new HQLCodeAssist( new SimpleConfigurationProvider(cfg));
			assist.CodeComplete("from MyEntity x where x in ( select y. from Referenced y)", 38, this);
            Assert.That(proposals.Count == 3);
        }

		[Test]
		public void WhenImportsDoesNotContainEntityNameThenNotThrow()
		{
			HQLCodeAssist assist = new HQLCodeAssist(new EmptyConfiguratorProvider());
			assist.CodeComplete("from xxxxxx e where ", 20, this);
			Assert.That(proposals.Any(q => q.SimpleName == "e"));
		}

        public static Configuration CreateCfg()
        {
            Configuration cfg = new Configuration();
            cfg.Properties[NHibernate.Cfg.Environment.Dialect] = typeof(NHibernate.Dialect.GenericDialect).FullName;
            cfg.AddAssembly(typeof(MyEntity).Assembly);
            cfg.CreateMappings(new NHibernate.Dialect.GenericDialect());
            return cfg;
        }
		
		private class EmptyConfiguratorProvider : IConfigurationDataProvider
		{
			public IDictionary<string, string> Imports
			{
				get { return new Dictionary<string, string>(); }
			}

			public IPersistentClassInformation GetClassMapping(string path)
			{
				return null;
			}

			public IPersistentClassInformation GetClassMapping(Type type)
			{
				return null;
			}
		}

        #region IHQLCompletionRequestor Members

        public bool Accept(HQLCompletionProposal proposal)
        {
            Console.WriteLine(proposal.ToString());
            proposals.Add(proposal);
            return false;
        }

        public void CompletionFailure(string errorMessage)
        {
            
        }

        #endregion
    }
}
