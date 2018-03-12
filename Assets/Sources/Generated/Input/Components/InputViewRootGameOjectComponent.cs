//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity viewRootGameOjectEntity { get { return GetGroup(InputMatcher.ViewRootGameOject).GetSingleEntity(); } }
    public ViewRootGameOjectComponent viewRootGameOject { get { return viewRootGameOjectEntity.viewRootGameOject; } }
    public bool hasViewRootGameOject { get { return viewRootGameOjectEntity != null; } }

    public InputEntity SetViewRootGameOject(UnityEngine.GameObject newGameObject) {
        if (hasViewRootGameOject) {
            throw new Entitas.EntitasException("Could not set ViewRootGameOject!\n" + this + " already has an entity with ViewRootGameOjectComponent!",
                "You should check if the context already has a viewRootGameOjectEntity before setting it or use context.ReplaceViewRootGameOject().");
        }
        var entity = CreateEntity();
        entity.AddViewRootGameOject(newGameObject);
        return entity;
    }

    public void ReplaceViewRootGameOject(UnityEngine.GameObject newGameObject) {
        var entity = viewRootGameOjectEntity;
        if (entity == null) {
            entity = SetViewRootGameOject(newGameObject);
        } else {
            entity.ReplaceViewRootGameOject(newGameObject);
        }
    }

    public void RemoveViewRootGameOject() {
        viewRootGameOjectEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public ViewRootGameOjectComponent viewRootGameOject { get { return (ViewRootGameOjectComponent)GetComponent(InputComponentsLookup.ViewRootGameOject); } }
    public bool hasViewRootGameOject { get { return HasComponent(InputComponentsLookup.ViewRootGameOject); } }

    public void AddViewRootGameOject(UnityEngine.GameObject newGameObject) {
        var index = InputComponentsLookup.ViewRootGameOject;
        var component = CreateComponent<ViewRootGameOjectComponent>(index);
        component.gameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceViewRootGameOject(UnityEngine.GameObject newGameObject) {
        var index = InputComponentsLookup.ViewRootGameOject;
        var component = CreateComponent<ViewRootGameOjectComponent>(index);
        component.gameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveViewRootGameOject() {
        RemoveComponent(InputComponentsLookup.ViewRootGameOject);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity : IViewRootGameOjectEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherViewRootGameOject;

    public static Entitas.IMatcher<InputEntity> ViewRootGameOject {
        get {
            if (_matcherViewRootGameOject == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.ViewRootGameOject);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherViewRootGameOject = matcher;
            }

            return _matcherViewRootGameOject;
        }
    }
}