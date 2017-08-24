# BarebonesObjectPooler
A simple Unity GameObject pooler

## What it is
BarebonesObjectPooler, or BOP, is a very simple object pool solution for Unity. It doesn't have a ton of options, and only works with GameObjects right now, but it works fine and gets the job done.

## Usage
Add the ObjectPoolManager script to any scene object (generally I like to create a new empty object called "Pool")

### Creating Pools
You can use the included ObjectPoolInitializer to easily specify a list of pooled objects and the initial size of those pools. There is a simple custom editor that lets you drag-and-drop objects into the inspector. 

You can also create pools programatically.
...
ObjectPoolManager.CreatePool(yourPrefab, initialPoolSize, parentTransform)
...

The parentTransform can be null, but if you provide it, the parent of inactive objects in the pool will be set to that transform.

### Getting and returning objects from pools
You can get objects from the pools just like you would if you were instantiating them.  
...
GameObject spawnedObject = ObjectPoolManager.GetObject(yourPrefab);
...

Returning objects is also simple
...
ObjectPoolManager.ReturnObject(spawnedObject);
...

### Other notes
The pools will grow as needed if you try and retrieve objects when the pool is empty.