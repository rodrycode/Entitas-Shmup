//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        static readonly SlowMotionComponent slowMotionComponent = new SlowMotionComponent();

        public bool isSlowMotion {
            get { return HasComponent(InputComponentIds.SlowMotion); }
            set {
                if(value != isSlowMotion) {
                    if(value) {
                        AddComponent(InputComponentIds.SlowMotion, slowMotionComponent);
                    } else {
                        RemoveComponent(InputComponentIds.SlowMotion);
                    }
                }
            }
        }

        public Entity IsSlowMotion(bool value) {
            isSlowMotion = value;
            return this;
        }
    }

    public partial class Pool {
        public Entity slowMotionEntity { get { return GetGroup(InputMatcher.SlowMotion).GetSingleEntity(); } }

        public bool isSlowMotion {
            get { return slowMotionEntity != null; }
            set {
                var entity = slowMotionEntity;
                if(value != (entity != null)) {
                    if(value) {
                        CreateEntity().isSlowMotion = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }
}

    public partial class InputMatcher {
        static IMatcher _matcherSlowMotion;

        public static IMatcher SlowMotion {
            get {
                if(_matcherSlowMotion == null) {
                    var matcher = (Matcher)Matcher.AllOf(InputComponentIds.SlowMotion);
                    matcher.componentNames = InputComponentIds.componentNames;
                    _matcherSlowMotion = matcher;
                }

                return _matcherSlowMotion;
            }
        }
    }
