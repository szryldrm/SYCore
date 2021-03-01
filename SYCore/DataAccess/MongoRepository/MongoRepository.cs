﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SYCore.Entities;
using SYCore.Settings.MongoSettings;

namespace SYCore.DataAccess.MongoRepository
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument>
        where TDocument : class, IDocument, new()
    {
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IMongoSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }

        public virtual IQueryable<TDocument> AsQueryable()
        {
            return _collection.AsQueryable();
        }

        public virtual Task<List<TDocument>> GetAll()
        {
            return _collection.Find(_ => true).ToListAsync();
        }

        public virtual IEnumerable<TDocument> FilterBy(
            Expression<Func<TDocument, bool>> filterExpression)
        {
            return _collection.Find(filterExpression).ToEnumerable();
        }

        public virtual IEnumerable<TProjected> FilterBy<TProjected>(
            Expression<Func<TDocument, bool>> filterExpression,
            Expression<Func<TDocument, TProjected>> projectionExpression)
        {
            return _collection.Find(filterExpression).Project(projectionExpression).ToEnumerable();
        }

        public virtual TDocument FindOne(FilterDefinition<TDocument> filterDefinition)
        {
            return _collection.Find(filterDefinition).FirstOrDefault();
        }

        public virtual Task<TDocument> FindOneAsync(FilterDefinition<TDocument> filterDefinition)
        {
            return Task.Run(() => _collection.Find(filterDefinition).FirstOrDefaultAsync());
        }

        public virtual TDocument FindById(string id)
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
            return _collection.Find(filter).SingleOrDefault();
        }

        public virtual Task<TDocument> FindByIdAsync(string id)
        {
            return Task.Run(() =>
            {
                var objectId = new ObjectId(id);
                var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
                return _collection.Find(filter).SingleOrDefaultAsync();
            });
        }

        public virtual void InsertOne(TDocument document)
        {
            _collection.InsertOne(document);
        }

        public virtual Task InsertOneAsync(TDocument document)
        {
            return Task.Run(() => _collection.InsertOneAsync(document));
        }

        public void InsertSubOne(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            _collection.UpdateOne(filter, update);
        }

        public Task InsertSubOneAsync(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            return Task.Run(() =>
            {
                return _collection.UpdateOneAsync(filter, update);
            });
        }

        public void InsertMany(ICollection<TDocument> documents)
        {
            _collection.InsertMany(documents);
        }


        public virtual async Task InsertManyAsync(ICollection<TDocument> documents)
        {
            await _collection.InsertManyAsync(documents);
        }

        public void ReplaceOne(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            _collection.FindOneAndReplace(filter, document);
        }

        public virtual async Task ReplaceOneAsync(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.FindOneAndReplaceAsync(filter, document);
        }

        public void UpdateSubOne(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            _collection.UpdateOne(filter, update);
        }

        public Task UpdateSubOneAsync(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            return Task.Run(() =>
            {
                return _collection.UpdateOneAsync(filter, update);
            });
        }

        public void DeleteSubOne(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            _collection.UpdateOne(filter, update);
        }

        public Task DeleteSubOneAsync(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update)
        {
            return Task.Run(() =>
            {
                return _collection.UpdateOneAsync(filter, update);
            });
        }

        public void DeleteOne(Expression<Func<TDocument, bool>> filterExpression)
        {
            _collection.FindOneAndDelete(filterExpression);
        }

        public Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            return Task.Run(() => _collection.FindOneAndDeleteAsync(filterExpression));
        }

        public void DeleteById(string id)
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
            _collection.FindOneAndDelete(filter);
        }

        public Task DeleteByIdAsync(string id)
        {
            return Task.Run(() =>
            {
                var objectId = new ObjectId(id);
                var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
                _collection.FindOneAndDeleteAsync(filter);
            });
        }

        public void DeleteMany(Expression<Func<TDocument, bool>> filterExpression)
        {
            _collection.DeleteMany(filterExpression);
        }

        public Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            return Task.Run(() => _collection.DeleteManyAsync(filterExpression));
        }
    }
}
