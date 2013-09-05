//
//  XMUtilities.h
//  XMBindingLibrarySample
//
//  Created by Anuj Bhatia on 1/18/12.
//  Copyright (c) 2012 __MyCompanyName__. All rights reserved.
//

#import <Foundation/Foundation.h>

// This is how to define a block function prototype.
typedef void (^XMUtilityCallback) (NSString *message);

@protocol MyDelegate 
-(void) run:(XMUtilityCallback) arg;
@end

@interface XMUtilities : NSObject {
	XMUtilityCallback _callback;
}

-(id) init;
+(NSString *) echo:(NSString *)message;
-(NSString *) hello:(NSString *)name;
-(NSInteger) add:(NSInteger)operandUn and:(NSInteger) operandDeux;
-(NSInteger) multiply:(NSInteger)operandUn and:(NSInteger)operandDeux;
-(void) setCallback:(XMUtilityCallback) callback;
-(void) invokeCallback:(NSString *) message;

// This will invoke the method "run:" on the target object with an int argument
-(NSString *) surface:(id<MyDelegate>) target;
@end
