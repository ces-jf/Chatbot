import React from 'react';
import {
	SafeAreaView,
	StatusBar,
	Text,
	View,
	StyleSheet,
} from 'react-native';

import Home from './src/home';

const App = () => {
	return (
		<View style={{ flex: 1 }}>
			<StatusBar barStyle="default" />
			<SafeAreaView style={styles.container}>
				<Home />
			</SafeAreaView>
		</View>
	);
};

const styles = StyleSheet.create({
	container: {
		flex: 1
	},
});


export default App;
